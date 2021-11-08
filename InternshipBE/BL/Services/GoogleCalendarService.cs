using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Microsoft.AspNetCore.Identity;
using Shared.Config.Interfaces;
using System;
using System.Threading.Tasks;

namespace BL.Services
{
	public class GoogleCalendarService : IGoogleCalendarService
	{
		private readonly string[] Scopes =
		{
			CalendarService.Scope.Calendar,
			CalendarService.Scope.CalendarEvents,
			CalendarService.Scope.CalendarEventsReadonly
		};
		private readonly UserManager<User> _userManager;
		private readonly IGoogleConfig _googleConfig;
		private CalendarService _calendarService;

		public GoogleCalendarService(IGoogleConfig googleConfig, IUnitOfWork unitOfWork, UserManager<User> userManager)
		{
			_userManager = userManager;
			_googleConfig = googleConfig;
		}

		public async Task CreateEventInCalendarAsync(string interviewerID, BestContactTimeDTO model)
		{
			var user = await _userManager.FindByIdAsync(interviewerID);

			CreateEvent(user.Email, model);
		}

		private void CreateEvent(string email, BestContactTimeDTO model)
		{
			var credential = GoogleCredential.FromFile(_googleConfig.ClientSecrets).CreateScoped(Scopes);

			_calendarService = new CalendarService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = _googleConfig.ApplicationName,
			});

			Event newEvent = new Event()
			{
				//All next rows with text will be moved to const variables."
				Summary = "Technical interview",
				Location = "Exadel. Minsk",
				Description = "Internship technical interview.",
				Start = new EventDateTime()
				{
					DateTime = model.StartTime,
				},
				End = new EventDateTime()
				{
					DateTime = model.EndTime,
				},
				Recurrence = new string[] { "RRULE:FREQ=DAILY;COUNT=2" }
			};

			EventsResource.InsertRequest request = _calendarService.Events.Insert(newEvent, email);
			request.Execute();
		}
	}
}
