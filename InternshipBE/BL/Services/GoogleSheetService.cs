using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Shared.Config.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Services
{
	public class GoogleSheetService : IGoogleSheetService
	{
		private readonly string Scope = SheetsService.Scope.Spreadsheets;
		private readonly IGoogleSheetConfig _sheetConfig;
		private readonly ICandidateRepository _candidateRepository;
		private IMapper _mapper;
		private SheetsService service;

		public GoogleSheetService(IGoogleSheetConfig sheetConfig, IMapper mapper, ICandidateRepository candidateRepository)
		{
			_candidateRepository = candidateRepository;
			_mapper = mapper;
			_sheetConfig = sheetConfig;
		}

		public async Task SaveNewCandidates()
		{
			var values = CheckCandidates().Result;

			if (values != null)
			{
				var models = _mapper.Map(values, new List<CandidateDTO>());
				var candidates = _mapper.Map(models, new List<Candidate>());

				await _candidateRepository.SaveListCandidatesAsync(candidates);
			}
			else
			{
				await Task.Run(() => throw new Exception("No new candidates was found"));
			}
		}

		private async Task<IList<IList<object>>> CheckCandidates()
		{
			var values = GetValuesFromTable().Skip(1);

			var candidates = await _candidateRepository.GetAllAsync();

			if (values.Count() > candidates.Count)
			{
				var newCandidates = values.Skip(candidates.Count).ToList();
				return newCandidates;
			}
			else
			{
				return null;
			}
		}

		private IList<IList<object>> GetValuesFromTable()
		{
			var credential = GoogleCredential.FromFile(_sheetConfig.ClientSecrets).CreateScoped(Scope);

			service = new SheetsService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = _sheetConfig.ApplicationName
			});

			var range = $"{_sheetConfig.Sheet}{_sheetConfig.RangeSettings}";
			var request = service.Spreadsheets.Values.Get(_sheetConfig.SpreadsheetId, range);

			var response = request.Execute();
			var values = response.Values;

			return values;
		}
	}
}

