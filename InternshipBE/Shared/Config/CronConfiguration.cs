using Hangfire;
using Microsoft.Extensions.Configuration;

namespace Shared.Config
{
	public static class CronConfiguration
	{
		public static string ReturnCron(IConfiguration configuration)
		{
			var cronConfig = configuration["CronSetting"];
			string format = null;

			switch (cronConfig)
			{
				case "Minuteli":
					format = Cron.Minutely();
					break;
				case "Hourly":
					format = Cron.Hourly();
					break;
			}

			return format;
		}
	}
}
