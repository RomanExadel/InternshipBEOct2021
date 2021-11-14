using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BestContactTimeController : ControllerBase
	{
		private readonly IBestContactTimeService _bestContactTimeService;

		public BestContactTimeController(IBestContactTimeService bestContactTimeService)
		{
			_bestContactTimeService = bestContactTimeService;
		}

		[HttpPost("setBestContactTime")]
		[Authorize]
		public async Task<IActionResult> SetBestContactTimeAsync([FromBody] List<BestContactTimeDTO> models)
		{
			var userName = User.Identity.Name;

			await _bestContactTimeService.SaveBestContactTimeAsync(userName, models);

			return Ok();
		}

		[HttpGet("{interviewerId}")]
		[Authorize]
		public async Task<IActionResult> GetAllBestContactTimeByUserIdAsync(string interviewerId)
		{
			var models = await _bestContactTimeService.GetAllBestTimeByIdAsync(interviewerId);

			return Ok(models);
		}
	}
}
