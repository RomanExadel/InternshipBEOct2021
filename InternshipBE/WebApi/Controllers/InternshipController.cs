using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternshipController : Controller
    {
        private readonly IInternshipService _internshipService;

        public InternshipController (IInternshipService internshipService)
        {
            _internshipService = internshipService; 
        }

        [HttpGet("GetInternshipById")]
        public async Task<IActionResult> GetInternshipById([FromQuery] int id)
        {
            var internship = await _internshipService.GetInternshipAsync(id); 
            
            return Ok(internship);
        } 

        [HttpPost("GetAllInternshipsPartial")]
        public async Task<IActionResult> GetAllInternshipsPartial([FromBody] AGGridBaseRequest body)
        {
            var internships = await _internshipService.GetAllInternshipsPartialAsync(body.ItemsCount, body.PageNumber);

            return Ok(internships);
        }

        [HttpPost("CreateInternship")]
        public async Task<IActionResult> CreateInternship ([FromBody] InternshipDTO internship)
        {
            return Ok(await _internshipService.CreateInternshipAsync(internship));
        }

        [HttpPut("UpdateInternship")]
        public async Task<IActionResult> UpdateInternship ([FromBody] InternshipDTO internship)
        {
            return Ok(await _internshipService.UpdateInternshipAsync(internship));
        }
    }
}
