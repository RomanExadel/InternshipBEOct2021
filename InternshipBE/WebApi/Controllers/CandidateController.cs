using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : Controller
    {
        private readonly ICandidateService _service;
        private readonly IMapper _mapper;

        public CandidateController(ICandidateService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
        [HttpGet("GetCandidateById")]
        public async Task<IActionResult> GetCandidateById([FromQuery] int candidateId)
        {
            var candidate = await _service.GetCandidateAsync(candidateId);

            return Ok(candidate);
        }

        [HttpPost("GetCandidateListByInternshipId")]
        public async Task<IActionResult> GetCandidateListByInternshipId([FromBody] GetCandidatesByInternshipIdRequest body)
        {
            var candidates = await _service.GetAllByInternshipIdAsync(body.InternshipId, body.ItemsCount, body.PageNumber);

            return Ok(candidates);
        }

        [HttpPost("CreateCandidate")]
        public async Task<IActionResult> CreateCandidate([FromBody] CandidateDTO candidate)
        {
            var createdCandidate = await _service.CreateCandidateAsync(candidate);

            return Ok(createdCandidate);
        }

        [HttpPut("UpdateCandidate")]
        public async Task<IActionResult> UpdateCandidate([FromBody] CandidateDTO candidate)
        {
            var updatedCandidate = await _service.UpdateCandidateAsync(candidate);

            return Ok(updatedCandidate);
        }
    }
}