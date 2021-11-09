using BL.DTOs;
using BL.DTOs.EvaluationDTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluationController : Controller
    {
        private readonly IEvaluationService _evaluationService;

        public EvaluationController(IEvaluationService evaluationService)
        {
            _evaluationService = evaluationService;
        }

        [HttpPost("createEvaluation")]
        public async Task<IActionResult> CreateEvaluation([FromBody] CreateEvaluationDTO createEvaluationDto)
        {
            return Ok(await _evaluationService.CreateEvaluationAsync(createEvaluationDto));
        }

        [HttpPost("getEvaluationsByFeedbackId")]
        public async Task<IActionResult> GetEvaluationsByFeedbackId([FromQuery] int feedbackId)
        {
            return Ok(await _evaluationService.GetEvaluationsByFeedbackId(feedbackId));
        }

        [HttpPut("updateEvaluation")]
        public async Task<ActionResult> UpdateEvaluation([FromBody] FullEvaluationDTO fullEvaluationDto)
        {
            return Ok(await _evaluationService.UpdateEvaluationAsync(fullEvaluationDto));
        }
    }
}
