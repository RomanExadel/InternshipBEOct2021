using BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Authorization;

namespace WebApi.Controllers
{
	[Route("api/authenticate")]
	[ApiController]
	public class AuthenticateController : ControllerBase
	{
		private readonly IUserService _userService; 
		public AuthenticateController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Post([FromBody] CredentialsViewModel credentials)
		{ 
			var token = _userService.Authenticate(credentials.Login, credentials.Password);

			if (token != null)
			{
				return Unauthorized(new 
				{
					errorText = "Invalid login or password."
				});
			}

			var response = new
			{
				accessToken = token
			};

			return Ok(response);
		}
	}
}
