using Microsoft.Extensions.Configuration;
using Shared.Config.Interfaces;

namespace Shared.Config
{
	public class GoogleSheetConfig : IGoogleSheetConfig
	{
		private readonly IConfiguration _configuration;

		public GoogleSheetConfig(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public string ApplicationName => _configuration["SheetsConfig:ApplicationName"];

		public string SpreadsheetId => _configuration["SheetsConfig:SpreadsheetId"];

		public string Sheet => _configuration["SheetsConfig:Sheet"];
	}
}
