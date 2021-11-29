using Microsoft.AspNetCore.Mvc;

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
    }
}
