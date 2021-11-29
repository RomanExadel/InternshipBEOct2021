using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Shared.Config.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Services
{
	public class GoogleSheetService : IGoogleSheetService
	{
		private readonly string Scope = SheetsService.Scope.Spreadsheets;
		private readonly IGoogleConfig _googleConfig;
		private readonly IUnitOfWork _unitOfWork;
		private IMapper _mapper;
		private SheetsService _sheetService;

		private const int COLUMN_NAMES_ROW = 1;

		public GoogleSheetService(IGoogleConfig googleConfig, IMapper mapper, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_googleConfig = googleConfig;
			_unitOfWork = unitOfWork;
		}

		public async Task SaveNewCandidatesAsync()
		{
			var values = await GetNewCandidatesAsync();

			if (values != null)
			{
				await SaveNewCountriesAsync(values);
				
				var candidates = _mapper.Map<List<Candidate>>(values);

				await _unitOfWork.Candidates.BulkSaveAsync(candidates);
			}
		}

		private async Task<List<CandidateDTO>> GetNewCandidatesAsync()
		{
			var newCandidates = new List<CandidateDTO>();

			var internships = await _unitOfWork.Internships.GetAllAsync();

			foreach (var internship in internships)
			{
				var values = GetValuesFromTable(internship.SpreadSheetId).Skip(COLUMN_NAMES_ROW);
				var candidatesAmount = await _unitOfWork.Candidates.GetCandidatesCountByTabelIdAsync(internship.SpreadSheetId);

				if (values.Count() > candidatesAmount)
				{
					var newCandidatesFromOneTable = _mapper.Map<List<CandidateDTO>>(values.Skip(candidatesAmount));
					newCandidatesFromOneTable.ForEach(x => x.InternshipId = internship.Id);
					newCandidates.AddRange(newCandidatesFromOneTable);
				}
			}

			return  newCandidates;
		}

		private IList<IList<object>> GetValuesFromTable(string spreadSheetId)
		{
			var credential = GoogleCredential.FromFile(_googleConfig.ClientSecrets).CreateScoped(Scope);

			_sheetService = new SheetsService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
			});

			var range = $"{_googleConfig.RangeSettings}";
			var request = _sheetService.Spreadsheets.Values.Get(spreadSheetId, range);

			var response = request.Execute();

			return response.Values;
		}

		private async Task SaveNewCountriesAsync(List<CandidateDTO> values)
		{
			var names = await _unitOfWork.Locations.GetLocationsAsync();

			var newNames = values.Select(x => x.Location).Except(names);

			var countries = _mapper.Map<List<Country>>(newNames);

			await _unitOfWork.Locations.BulkSaveAsync(countries);
		}
	}
}


