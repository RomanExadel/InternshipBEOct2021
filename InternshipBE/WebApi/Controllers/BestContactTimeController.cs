using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BestContactTimeController : ControllerBase
	{
		private readonly IBestContactTimeService _bestContactTimeService;
		private readonly IMapper _mapper;

		public BestContactTimeController(IBestContactTimeService bestContactTimeService, IMapper mapper)
		{
			_bestContactTimeService = bestContactTimeService;
			_mapper = mapper;
		}

		[HttpPost("setBestContactTime")]
		[Authorize]
		public async Task<IActionResult> SetBestContactTimeAsync([FromBody] BestContactTimeDTO model)
		{
			var userName = User.Identity.Name;

			await _bestContactTimeService.SaveBestContactTimeAsync(userName, model);

			return Ok();
		}

		[HttpGet("GetAllBestContactTimeByUserId")]
		[Authorize]
		public async Task<IActionResult> GetAllBestContactTimeByUserId([FromBody] string interviewerId)
		{
			var models = await _bestContactTimeService.GetAllBestTimeByIdAsync(interviewerId);

			return Ok(new { models });
		}
	}
}
