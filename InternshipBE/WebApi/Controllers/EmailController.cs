﻿using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController: Controller
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("sendEmail")]
        public async Task<IActionResult> SendEmailAsync ([FromQuery] int toId, [FromQuery] string subject, [FromQuery] string text)
        {
            await _emailService.SendEmailAsync(toId, subject, text);
            return Ok();
        }


    }
}
