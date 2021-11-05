using BL.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Shared.Config.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Apis.Calendar.v3.CalendarService;

namespace BL.Services
{
	public class GoogleCalendarService : IGoogleCalendarService
	{
		private readonly string Scope = CalendarService.Scope.CalendarEventsReadonly;
		private readonly IGoogleConfig _googleConfig;
		private CalendarService _calendarService;

		public GoogleCalendarService(IGoogleConfig googleConfig)
		{
			_googleConfig = googleConfig;
		}

		public async Task<Events> GetCalendarEvents()
		{
			var events = GetEventsFromCalendar();

			return events;
		}

		private Events GetEventsFromCalendar()
		{
			var credential = GoogleCredential.FromFile(_googleConfig.ClientSecrets).CreateScoped(Scope);

			var _calendarService = new CalendarService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = _googleConfig.ApplicationName,
			});

			EventsResource.ListRequest request = _calendarService.Events.List("primary");
			request.TimeMin = DateTime.Now;
			request.ShowDeleted = false;
			request.SingleEvents = true;
			request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

			Events events = request.Execute();

			return events;
		}
	}
}
