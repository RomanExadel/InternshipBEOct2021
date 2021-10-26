using BL.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Shared.Config.Interfaces;
using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace BL.Services
{
	public class GoogleSheetService : IGoogleSheetService
	{
		private readonly string Scope = SheetsService.Scope.Spreadsheets;
		private readonly IGoogleSheetConfig _sheetConfig;
		private SheetsService service;

		public GoogleSheetService(IGoogleSheetConfig sheetConfig)
		{
			_sheetConfig = sheetConfig;
		}

		public string ReadEntries()
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

			if (values != null && values.Count > 0)
			{
				var options = new JsonSerializerOptions
				{
					Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
					WriteIndented = true
				};
				string json = JsonSerializer.Serialize(values, options);

				return json;
			}
			else
			{
				throw new Exception("No data was found");
			}
		}
	}
}

