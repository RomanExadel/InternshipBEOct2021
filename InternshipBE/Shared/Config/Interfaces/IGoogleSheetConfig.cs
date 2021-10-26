namespace Shared.Config.Interfaces
{
	public interface IGoogleSheetConfig
	{ 
		public  string ApplicationName { get; }

		public string SpreadsheetId { get; }

		public string Sheet { get; }

		public string RangeSettings { get; }

		public string ClientSecrets { get; }
	}
}
