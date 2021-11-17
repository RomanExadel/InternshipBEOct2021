using BL.DTOs;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Enums;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpPost("createSkill")]
        public async Task<IActionResult> CreateSkill([FromBody] SkillDTO skillDto)
        {
            return Ok(await _skillService.CreateSkillAsync(skillDto));
        }

        [HttpPut("updateSkill")]
        public async Task<IActionResult> UpdateSkill([FromBody] SkillDTO skillDTO)
        {
            return Ok(await _skillService.UpdateSkillAsync(skillDTO));
        }

        [HttpGet("getSkillsByStackType")]
        public async Task<IActionResult> GetSkillsByStackType([FromQuery] StackType stackType)
        {
            return Ok(await _skillService.GetSkillsByStackTypeAsync(stackType));
        }
    }
}
