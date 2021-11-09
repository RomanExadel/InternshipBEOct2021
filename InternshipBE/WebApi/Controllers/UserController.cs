using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

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

        [HttpGet("getUserInfo")]
        public async Task<IActionResult> GetUserInfo()
        {
            var userName = User.Identity.Name;

            return Ok(await _userService.GetUserInfoByUserNameAsync(userName));
        }

        [HttpGet("getSpecificUsersByInternshipId")]
        public async Task<IActionResult> GetSpecificUsersByInternshipId([FromQuery] GetSpecificUsersRequest usersRequest)
        {
            return Ok(await _userService.GetSpecificUsersByInternshipIdAsync(usersRequest.Id, usersRequest.RoleType));
        }

        [HttpGet("getUsersByCandidateId")]
        public async Task<IActionResult> GetUsersByCandidateId([FromQuery] int id) 
        {                       
            return Ok(await _userService.GetUsersByCandidateIdAsync(id));
        }

        [HttpPut("updateUsersFromInternship")]
        public async Task<IActionResult> UpdateUsersFromInternship([FromQuery] int id, [FromBody] string[] usersId)
        {
            return Ok(await _userService.UpdateUsersFromInternshipAsync(id, usersId));
        }
    }
}
