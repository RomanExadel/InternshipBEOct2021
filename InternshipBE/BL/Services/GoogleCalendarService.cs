using AutoMapper;
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

		public async Task CreateEventInCalendarAsync(EventDTO model)
		{
			var user = await _userManager.FindByEmailAsync(model.InterviewerEmail);

			CreateEvent(model);

			var bestContactTime = _mapper.Map<BestContactTime>(model);

			bestContactTime.User = user;
			bestContactTime.UserId = user.Id;
			bestContactTime = await _unitOfWork.BestContactTime.GetByTimeIntervalAsync(bestContactTime);

			await _unitOfWork.BestContactTime.DeleteAsync(bestContactTime);
		}

		private void CreateEvent(EventDTO model)
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

			EventsResource.InsertRequest request = _calendarService.Events.Insert(newEvent, model.InterviewerEmail);
			request.Execute();
		}
	}
}
