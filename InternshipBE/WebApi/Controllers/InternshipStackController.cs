using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternshipStackController : Controller
    {
        private readonly IInternshipStackService _internshipStackService;

        public InternshipStackController(IInternshipStackService internshipStackService)
        {
            _internshipStackService = internshipStackService;
        }

        [HttpGet("getInternshipStacks")]
        public async Task<IActionResult> GetInternshipStacksByInternshipId()
        {
            return Ok(await _internshipStackService.GetInternshipStacksAsync());
        }

        [HttpGet("getInternshipStacksByInternshipId")]
        public async Task<IActionResult> GetInternshipStacksByInternshipId([FromQuery] int internshipId)
        {
            return Ok(await _internshipStackService.GetInternshipStacksByInternshipIdAsync(internshipId));
        }

        [HttpPost("createInternshipStacksByInternshipId")]
        public async Task<IActionResult> CreateInternshipStackByInternshipId([FromBody] InternshipStackDTO internshipStackDto)
        {
            return Ok(await _internshipStackService.CreateInternshipStackAsync(internshipStackDto));
        }

        [HttpPut("updateInternshipStackById")]
        public async Task<IActionResult> UpdateInternshipStackById([FromBody] InternshipStackDTO internshipStackDto)
        {
            return Ok(await _internshipStackService.UpdateInternshipStackAsync(internshipStackDto));
        }
    }
}
