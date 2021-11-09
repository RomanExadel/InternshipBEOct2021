using AutoMapper;
using BL.DTOs.BestContactTimeDTO;
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
using System.Text.Json.Serialization;
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
		private readonly ICalendarEventsConfig _calendarEventsConfig;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public GoogleCalendarService(IGoogleConfig googleConfig, IUnitOfWork unitOfWork, UserManager<User> userManager, ICalendarEventsConfig calendarEventsConfig, IMapper mapper)
		{
			_userManager = userManager;
			_googleConfig = googleConfig;
			_calendarEventsConfig = calendarEventsConfig;
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task CreateEventInCalendarAsync(BestContactTimeEventDTO model)
		{
			var user = await _userManager.FindByIdAsync(model.InterviewerId);

			CreateEvent(user.Email, model);

			//var bestContactTime = await _unitOfWork.BestContactTime.GetByTimeIntervalAsync(model.StartTime, model.EndTime);
			//bestContactTime.User = user;

			//await _unitOfWork.BestContactTime.DeleteAsync(bestContactTime);
		}

		private void CreateEvent(string email, CreateBestContactTimeDTO model)
		{
			var credential = GoogleCredential.FromFile(_googleConfig.ClientSecrets).CreateScoped(Scopes);

			_calendarService = new CalendarService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = _googleConfig.ApplicationName,
			});

			Event newEvent = new Event()
			{
				Summary = _calendarEventsConfig.Summary,
				Location = _calendarEventsConfig.Location,
				Description = _calendarEventsConfig.Description,
				Start = new EventDateTime()
				{
					DateTime = model.StartTime,
					TimeZone = _calendarEventsConfig.TimeZone,
				},
				End = new EventDateTime()
				{
					DateTime = model.EndTime,
					TimeZone = _calendarEventsConfig.TimeZone,
				},
			};

			EventsResource.InsertRequest request = _calendarService.Events.Insert(newEvent, email);
			request.Execute();
		}
	}
}
