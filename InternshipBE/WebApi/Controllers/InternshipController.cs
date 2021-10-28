using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using BL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
<<<<<<< HEAD
using WebApi.Models;
=======
>>>>>>> 6b6dd06 (Implement Internship service and controller. Implement API for Create, Update, Get one and Get all internships.)

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternshipController : Controller
    {
        private readonly IInternshipService _service;

        public InternshipController (IInternshipService service)
        {
            _service = service; 
        }

        [HttpGet("GetInternshipById")]
        public async Task<IActionResult> GetInternshipById([FromQuery] int id)
        {
            var internship = await _service.GetInternshipAsync(id); 
            
            return Ok(internship);
        } 

<<<<<<< HEAD
        [HttpPost("GetAllInternshipsPartial")]
        public async Task<IActionResult> GetAllInternshipsPartial([FromBody] GetAllInternshipsRequest body)
        {
            var internships = await _service.GetAllInternshipsPartialAsync(body.ItemsCount, body.PageNumber);
=======
        [HttpGet("GetAllInternships")]
        public async Task<IActionResult> GetAllInternships()
        {
            var internships = await _service.GetAllInternshipAsync();
>>>>>>> 6b6dd06 (Implement Internship service and controller. Implement API for Create, Update, Get one and Get all internships.)

            return Ok(internships);
        }

        [HttpPost("CreateInternship")]
        public async Task<IActionResult> CreateInternship ([FromBody] InternshipDTO internship)
        {
          return Ok(await _service.CreateInternshipAsync(internship));
        }

        [HttpPut("UpdateInternship")]
        public async Task<IActionResult> UpdateInternship ([FromBody] InternshipDTO internship)
        {
            return Ok(await _service.UpdateInternshipAsync(internship));
        }
    }
}
