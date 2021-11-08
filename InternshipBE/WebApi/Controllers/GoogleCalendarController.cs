using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GoogleCalendarController : ControllerBase
	{
		private readonly IGoogleCalendarService _googleCalendarService;

		public GoogleCalendarController(IGoogleCalendarService googleCalendarService)
		{
			_googleCalendarService = googleCalendarService;
		}

		[HttpPost("setEventToGoogleCalendar")]
		[Authorize]
		public async Task<IActionResult> SetEventToGoogleCalendar([FromBody] string interviewerId, BestContactTimeDTO model)
		{
			await _googleCalendarService.CreateEventInCalendarAsync(interviewerId, model);

			return Ok();
		}
	}
}
