using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Shared.Config.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.Services
{
	public class GoogleSheetService : IGoogleSheetService
	{
		private readonly string Scope = SheetsService.Scope.Spreadsheets;
		private readonly IGoogleSheetConfig _sheetConfig;
		private IMapper _mapper; 
		private SheetsService service;

		public GoogleSheetService(IGoogleSheetConfig sheetConfig, IMapper mapper)
		{
			_mapper = mapper;
			_sheetConfig = sheetConfig;
		}

		public void SaveNewToDataBase()
		{
			var values = CheckNew();

			if (values != null)
			{
				var models = _mapper.Map(values, new List<CandidateDTO>());
				var candidates = _mapper.Map(models, new List<Candidate>());

				//When UnitOfWork will be added, we going to change this row.
				//_candidateService.AddListAsync(candidates); 
			}
			else
			{
				throw new Exception("No data was found");
			}
		}

		private IList<IList<object>> CheckNew()
		{
			var values = GetValuesFromTable();
			values.RemoveAt(0);

			//When UnitOfWork will be added, we going to change this row.
			//var candidates = _genericCandidate.GetAll().Result;

			if (values.Count > candidates.Count)
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

