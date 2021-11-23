using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class SkillDTOValidator : AbstractValidator<SkillDTO>
    {
        public SkillDTOValidator()
        {
            RuleFor(skill => skill.Id).NotEqual(0);
        }       
    }
}
