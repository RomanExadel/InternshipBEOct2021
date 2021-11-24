using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class SkillDTOValidator : AbstractValidator<SkillDTO>
    {
        public SkillDTOValidator()
        {
            RuleFor(skill => skill.IsHardSkill).NotNull();
            RuleFor(skill => skill.Name).NotEmpty();
            RuleFor(skill => skill.StackType).NotEmpty();
        }       
    }
}
