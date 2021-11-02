using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : Controller
    {
        private readonly ICandidateService _candidateService;

        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }
        
        [HttpGet("getCandidateById")]
        public async Task<IActionResult> GetCandidateById([FromQuery] int id)
        {
            var candidate = await _candidateService.GetCandidateByIdAsync(id);

            return Ok(candidate);
        }

        [HttpPost("getCandidateListByInternshipId")]
        public async Task<IActionResult> GetCandidateListByInternshipId([FromBody] GetCandidatesByInternshipIdRequest request)
        {
            var candidates = await _candidateService.GetCandidatesByInternshipIdAsync(request.InternshipId, request.PageSize, request.PageNumber);

            return Ok(candidates);
        }

        [HttpPost("createCandidate")]
        public async Task<IActionResult> CreateCandidate([FromBody] CandidateDTO candidate)
        {
            var createdCandidate = await _candidateService.CreateCandidateAsync(candidate);

            return Ok(createdCandidate);
        }

        [HttpPut("updateCandidate")]
        public async Task<IActionResult> UpdateCandidate([FromBody] CandidateDTO candidate)
        {
            var updatedCandidate = await _candidateService.UpdateCandidateAsync(candidate);

            return Ok(updatedCandidate);
        }
    }
}