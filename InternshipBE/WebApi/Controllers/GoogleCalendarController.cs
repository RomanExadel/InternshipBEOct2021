using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
		public async Task<IActionResult> SetEventToGoogleCalendarAsync([FromBody] EventDTO model)
		{
			await _googleCalendarService.CreateEventInCalendarAsync(model);

			return Ok();
		}
	}
}
