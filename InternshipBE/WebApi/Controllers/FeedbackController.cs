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
        public async Task<IActionResult> CreateFeedback([FromBody] FeedbackDTO feedbackDto)
        {
            return Ok(await _feedbackService.CreateFeedbackAsync(feedbackDto));
        }

        [HttpPut("updateFeedback")]
        public async Task<IActionResult> UpdateFeedback([FromBody] FeedbackDTO updateFeedback)
        {
            return Ok(await _feedbackService.UpdateFeedbackAsync(updateFeedback));
        }

        [HttpPost("getFeedbacksByCandidateId")]
        public async Task<IActionResult> GetFeedbacksByCandidateId ([FromQuery] int candidateId)
        {
            return Ok(await _feedbackService.GetFeedbacksByCandidateIdAsync(candidateId));
        }
    }
}
