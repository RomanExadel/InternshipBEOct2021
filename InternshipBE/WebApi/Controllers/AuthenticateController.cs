using BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Models;

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
		public async Task<IActionResult> Login([FromBody] CredentialsViewModel credentials)
		{ 
			var token = await _userService.AuthenticateAsync(credentials.Email, credentials.Password);

			if (string.IsNullOrWhiteSpace(token))
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
