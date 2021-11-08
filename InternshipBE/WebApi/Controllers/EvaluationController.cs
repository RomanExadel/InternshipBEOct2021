using BL.DTOs;
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
        public async Task<IActionResult> CreateEvaluation([FromBody] EvaluationDTO evaluationDto)
        {
            return Ok(await _evaluationService.CreateEvaluationAsync(evaluationDto));
        }
    }
}
