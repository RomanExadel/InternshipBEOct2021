using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Enums;
using System.Collections.Generic;
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
            return Ok(await _candidateService.GetCandidatesByInternshipIdAsync(request.InternshipId, request.PageSize, request.PageNumber, request.CandidatesFilterBy, request.SortBy, request.Asc));
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

        [Authorize(Roles = "Hr")]
        [HttpPut("updateCandidatesStatus")]
        public async Task<IActionResult> UpdateCandidateStatusById([FromBody] List<int> candidatesId, CandidateStatusType status)
        {
            var userName = User.Identity.Name;

            return Ok(await _candidateService.UpdateCandidateStatusByIdAsync(candidatesId, status, userName));
        }

        [Authorize]
        [HttpPost("candidateSearch")]
        public async Task<IActionResult> SearchCandidates([FromBody] CandidateDTO searchModel)
        {
            var searchResult = await _candidateService.SearchByInternshipIdAsync(searchModel);

            return Ok(searchResult);
        }
    }
}