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

        [HttpGet("getInternshipById")]
        public async Task<IActionResult> GetInternshipById([FromQuery] int id)
        {          
            return Ok(await _internshipService.GetInternshipByIdAsync(id));
        } 

        [HttpPost("getInternships")]
        public async Task<IActionResult> GetInternships([FromBody] AGGridInternshipsFilter request)
        {
            return Ok(await _internshipService.GetInternshipsAsync(request.PageSize, request.PageNumber, request.IntershipsFilterBy));
        }

        [HttpPost("createInternship")]
        public async Task<IActionResult> CreateInternship([FromBody] InternshipDTO internship)
        {
            return Ok(await _internshipService.CreateInternshipAsync(internship));
        }

        [HttpPut("updateInternship")]
        public async Task<IActionResult> UpdateInternship([FromBody] InternshipDTO internship)
        {
            return Ok(await _internshipService.UpdateInternshipAsync(internship));
        }
    }
}
