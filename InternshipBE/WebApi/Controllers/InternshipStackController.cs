using BL.DTOs.InternshipStackDTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    public class InternshipStackController : Controller
    {
        private readonly IInternshipStackService _internshipStackService;

        public InternshipStackController(IInternshipStackService internshipStackService)
        {
            _internshipStackService = internshipStackService;
        }

        [HttpGet("getInternshipStacksByInternshipId")]
        public async Task<IActionResult> GetInternshipStacksByInternshipId([FromQuery] int internshipId)
        {
            return Ok(await _internshipStackService.GetInternshipStacksByInternshipIdAsync(internshipId));
        }

        [HttpPost("createInternshipStacksByInternshipId")]
        public async Task<IActionResult> CreateInternshipStackByInternshipId([FromBody] CreateInternshipStackDTO internshipStackDto)
        {
            return Ok(await _internshipStackService.CreateInternshipStackAsync(internshipStackDto));
        }
    }
}
