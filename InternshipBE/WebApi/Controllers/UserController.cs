using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace WebApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUserInfo")]
        public async Task<IActionResult> GetUserInfo([FromQuery] string userId)
        {
            var user = await _userService.GetUserInfoAsync(userId);

            if (user == null) 
            {
                return BadRequest("Invalid input data");
            }

            return Ok(user);
        }
    }
}
