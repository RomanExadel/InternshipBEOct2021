using BL.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BL.Services
{
	public class GoogleSheetService : IGoogleSheetService
	{
		private readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
		private readonly string ApplicationName = "ExampleCSharp";
		private readonly string SpreadsheetId = "1PokdyP8f8tWaJlE0NQvF2taCKthzc-iy8lbWLubrAek";
		private readonly string sheet = "Answers";
		private SheetsService service;
		private readonly IConfiguration _configuration;

		public GoogleSheetService(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public string ReadEntries()
		{
			GoogleCredential credential;

			//var conf = _configuration.GetSection("GoogleCredentials").GetChildren().ToString();

			//credential = GoogleCredential.FromJson(conf)
			//		.CreateScoped(Scopes);

			using (var stream = new FileStream("C:\\Users\\Vladimir\\Exadel\\InternshipBEOct2021\\InternshipBE\\WebApi\\client_secrets.json", FileMode.Open, FileAccess.Read))
			{
				credential = GoogleCredential.FromStream(stream)
					.CreateScoped(Scopes);
			}

			service = new SheetsService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = ApplicationName,
			});

			var range = $"{sheet}!A1:F15";
			var request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

			var response = request.Execute();
			var values = response.Values;
			try
			{
				if (values != null && values.Count > 0)
				{
					string json = JsonSerializer.Serialize(values);

					return json;
				}
				else
				{
					throw new Exception("No data was found");
				}
			}
			catch(Exception e)
			{
				return e.Message;
			}
		}
	}
}
