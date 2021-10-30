using AutoMapper;
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
        private readonly IMapper _mapper;

        public CandidateController(ICandidateService candidateService, IMapper mapper)
        {
            _candidateService = candidateService;
            _mapper = mapper;
        }
        
        [HttpGet("GetCandidateById")]
        public async Task<IActionResult> GetCandidateById([FromQuery] int candidateId)
        {
            var candidate = await _candidateService.GetCandidateByIdAsync(candidateId);

            return Ok(candidate);
        }

        [HttpPost("GetCandidateListByInternshipId")]
        public async Task<IActionResult> GetCandidateListByInternshipId([FromBody] GetCandidatesByInternshipIdRequest request)
        {
            var candidates = await _candidateService.GetAllByInternshipIdAsync(request.InternshipId, request.PageSize, request.PageNumber);

            return Ok(candidates);
        }

        [HttpPost("CreateCandidate")]
        public async Task<IActionResult> CreateCandidate([FromBody] CandidateDTO candidate)
        {
            var createdCandidate = await _candidateService.CreateCandidateAsync(candidate);

            return Ok(createdCandidate);
        }

        [HttpPut("UpdateCandidate")]
        public async Task<IActionResult> UpdateCandidate([FromBody] CandidateDTO candidate)
        {
            var updatedCandidate = await _candidateService.UpdateCandidateAsync(candidate);

            return Ok(updatedCandidate);
        }
    }
}