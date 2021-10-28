using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using BL.Services;
using Microsoft.AspNetCore.Http;
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
            var internship = await _internshipService.GetInternshipByIdAsync(id); 
            
            return Ok(internship);
        } 

        [HttpPost("getInternships")]
        public async Task<IActionResult> GetInternships([FromBody] AGGridBaseRequest request)
        {
            var internships = await _internshipService.GetInternshipsAsync(request.PageSize, request.PageNumber);

            return Ok(internships);
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
