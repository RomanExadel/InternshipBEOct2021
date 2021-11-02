using Hangfire;
using Microsoft.Extensions.Configuration;
using static Shared.Constants.CronConstants;

namespace Shared.Config
{
	public static class CronConfiguration
	{
		public static string SetCron(IConfiguration configuration)
		{
			switch (configuration["CronSetting"])
			{
				case Minuteli:
					return Cron.Minutely();
				case Hourly:
					return Cron.Hourly();
				default:
					return Cron.Minutely();
			}
		}
	}
}
