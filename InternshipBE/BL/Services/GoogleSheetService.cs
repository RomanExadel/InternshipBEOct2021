using AutoMapper;
using BL.DTOs.CandidateDTOs;
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
using static Shared.Constants.ImportFileOffsets;

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
				
				var models = _mapper.Map<List<CandidateDTO>>(values);
				var candidates = _mapper.Map<List<Candidate>>(models);

				await _unitOfWork.Candidates.BulkSaveAsync(candidates);
			}
		}

		private async Task<IList<IList<object>>> GetNewCandidatesAsync()
		{
			var values = GetValuesFromTable().Skip(COLUMN_NAMES_ROW);
			var candidatesAmount = await _unitOfWork.Candidates.GetCandidatesCountAsync();

			if (values.Count() > candidatesAmount)
			{

				var newCandidates = values.Skip(candidatesAmount).ToList();
				return newCandidates;
			}
			return null;
		}

		private IList<IList<object>> GetValuesFromTable()
		{
			var credential = GoogleCredential.FromFile(_googleConfig.ClientSecrets).CreateScoped(Scope);

			_sheetService = new SheetsService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = _googleConfig.ApplicationName
			});

			var range = $"{_googleConfig.Sheet}{_googleConfig.RangeSettings}";
			var request = _sheetService.Spreadsheets.Values.Get(_googleConfig.SpreadsheetId, range);

			var response = request.Execute();

			return response.Values;
		}

		private async Task SaveNewCountriesAsync(IList<IList<object>> values)
		{
			var names = await _unitOfWork.Locations.GetAllNamesAsync();
			var newNames = values.Select(x => x[LOCATION_OFFSET].ToString()).ToList().Distinct().Except(names);

			var countries = _mapper.Map<List<Country>>(newNames);

			await _unitOfWork.Locations.BulkSaveAsync(countries);
		}
	}
}


