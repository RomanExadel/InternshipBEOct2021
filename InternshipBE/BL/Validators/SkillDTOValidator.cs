using BL.DTOs;
using FluentValidation;

namespace BL.Validators
{
    public class SkillDTOValidator : AbstractValidator<SkillDTO>
    {
        public SkillDTOValidator()
        {
            RuleFor(skill => skill.Id).NotEqual(0).WithMessage( x => $"The Id {x.Id} is not valid");
        }       
    }
}
