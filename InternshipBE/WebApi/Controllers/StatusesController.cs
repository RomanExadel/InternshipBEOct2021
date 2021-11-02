using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Enums;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusesController : Controller
    {
        private readonly ICandidateService _candidateService;

        public StatusesController(ICandidateService service)
        {
            _candidateService = service;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCandidate(StatusType status, int id)
        {
            var updateCandidateStatus = await _candidateService.ChangeCandidateStatus(status, id);
            return Ok(updateCandidateStatus);
        }
    }
}
