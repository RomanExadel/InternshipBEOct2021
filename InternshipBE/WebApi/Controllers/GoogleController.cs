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
	public class GoogleController : ControllerBase
	{
		private readonly IGoogleSheetService _googleSheetService;
		public GoogleController(IGoogleSheetService googleSheetService)
		{
			_googleSheetService = googleSheetService;
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult GetData()
		{
			var json = _googleSheetService.ReadEntries();
			return Ok(new {json});
		}

	}
}
