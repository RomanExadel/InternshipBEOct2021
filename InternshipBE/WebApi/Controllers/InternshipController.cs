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

        [HttpPost("GetAllInternshipsPartial")]
        public async Task<IActionResult> GetAllInternshipsPartial([FromBody] AGGridBaseRequest body)
        {
            var internships = await _service.GetAllInternshipsPartialAsync(body.ItemsCount, body.PageNumber);

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
