using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewInviteController : Controller
    {
        private readonly IInterviewInviteService _interviewInviteService;
        
        public InterviewInviteController(IInterviewInviteService interviewInviteService)
        {
            _interviewInviteService = interviewInviteService;
        }

        [HttpGet("getAllInterviewInvites")]
        public async Task<IActionResult> GetAllInterviewInvites()
        {
            return Ok(await _interviewInviteService.GetAllInterviewInvitesAsync());
        }

        [HttpGet("getInterviewInvitesByUserId")]
        public async Task<IActionResult> GetInterviewInvitesByUserId([FromQuery] string userId)
        {
            return Ok(await _interviewInviteService.GetInterviewInvitesByUserIdAsync(userId));
        }

        [HttpPost("createInterviewInvite")]
        public async Task<IActionResult> CreateInterviewInvite([FromBody] InterviewInviteDTO inviteDto)
        {
            return Ok(await _interviewInviteService.CreateInterviewInviteAsync(inviteDto));
        }
    }
}
