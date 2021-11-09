using Microsoft.Extensions.Configuration;
using Shared.Config.Interfaces;

namespace Shared.Config
{
	public class CalendarEventsConfig : ICalendarEventsConfig
	{
		private readonly IConfiguration _configuration;

		public CalendarEventsConfig(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public string Summary => _configuration["CalendarEventsConfig:Summary"];

		public string Location => _configuration["CalendarEventsConfig:Location"];

		public string Description => _configuration["CalendarEventsConfig:Description"];

		public string Recurrence => _configuration["CalendarEventsConfig:Recurrence"];

		public string TimeZone => _configuration["CalendarEventsConfig:TimeZone"];
	}
}
