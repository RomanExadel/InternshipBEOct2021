using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet("getFeedbackById")]
        public async Task<IActionResult> GetFeedbackById([FromQuery] int id)
        {
            return Ok(await _feedbackService.GetFeedbackByIdAsync(id));
        }

        [HttpPost("createFeedback")]
        public async Task<IActionResult> CreateFeedback([FromBody] FeedbackDTO feedback)
        {
            return Ok(await _feedbackService.CreateFeedbackAsync(feedback));
        }

        [HttpPost("updateFeedback")]
        public async Task<IActionResult> UpdateFeedback([FromBody] FeedbackDTO feedback)
        {
            return Ok(await _feedbackService.UpdateFeedbackAsync(feedback));
        }

        [HttpPost("getFeedbacksByCandidateId")]
        public async Task<IActionResult> GetFeedbacksByCandidateId ([FromQuery] int candidateId)
        {
            return Ok(await _feedbackService.GetFeedbacksByCandidateIdAsync(candidateId));
        }
    }
}
