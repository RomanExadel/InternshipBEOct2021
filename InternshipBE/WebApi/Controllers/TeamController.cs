using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("getTeamsByInternshipId")]
        public async Task<IActionResult> GetTeamsByInternshipId([FromQuery] int internshipId)
        {
            return Ok(await _teamService.GetTeamsByInternshipIdAsync(internshipId));
        }

        [HttpPost("createTeamsByInternshipId")]
        public async Task<IActionResult> CreateTeamByInternshipId([FromBody] TeamDTO team)
        {
            return Ok(await _teamService.CreateTeamByInternshipIdAsync(team));
        }
    }
}
