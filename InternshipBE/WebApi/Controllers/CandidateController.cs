using BL.DTOs.CandidateDTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Enums;
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
            return Ok(await _candidateService.GetCandidateByIdAsync(id));
        }

        [HttpPost("getCandidateListByInternshipId")]
        public async Task<IActionResult> GetCandidateListByInternshipId([FromBody] GetCandidatesByInternshipIdRequest request)
        {
            return Ok(await _candidateService.GetCandidatesByInternshipIdAsync(request.InternshipId, request.PageSize, request.PageNumber, request.CandidatesFilterBy));
        }

        [HttpPost("createCandidate")]
        public async Task<IActionResult> CreateCandidate([FromBody] CandidateDTO candidate)
        {
            return Ok(await _candidateService.CreateCandidateAsync(candidate));
        }

        [HttpPut("updateCandidate")]
        public async Task<IActionResult> UpdateCandidate([FromBody] CandidateDTO candidate)
        {
            return Ok(await _candidateService.UpdateCandidateAsync(candidate));
        }

        [HttpPut("updateCandidateStatus/{id}")]
        public async Task<IActionResult> UpdateCandidateStatusById(int id, CandidateStatusType status)
        {
            return Ok(await _candidateService.UpdateCandidateStatusByIdAsync(id, status));
        }

        [Authorize]
        [HttpPost("candidateSearch")]
        public async Task<IActionResult> SearchCandidate([FromBody] CandidateDTO searchModel)
        {
            var searchResult = await _candidateService.SearchAsync(searchModel);

            return Ok(searchResult);
        }
    }
}