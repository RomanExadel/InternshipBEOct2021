using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
	[Route("api/hangfire")]
	[ApiController]
	public class HangfireController : ControllerBase
	{
		private readonly IGoogleSheetService _googleSheetService;

		public HangfireController(IGoogleSheetService googleSheetService)
		{
			_googleSheetService = googleSheetService;
		}

		[HttpGet]
		public async Task<IActionResult> UpdateCandidatesAsync()
		{
			await _googleSheetService.SaveNewCandidatesAsync();

			return Ok();
		}	
	}
}
