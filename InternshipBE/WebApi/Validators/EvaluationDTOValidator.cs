using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class EvaluationDTOValidator : AbstractValidator<EvaluationDTO>
    {
        public EvaluationDTOValidator()
        {
            RuleFor(evaluation => evaluation.SkillId).NotEqual(0);
            RuleFor(evaluation => evaluation.FeedbackId).NotEqual(0);
            RuleFor(evaluation => evaluation.Value).NotEqual(0);
            RuleFor(evaluation => evaluation.Skill).NotEmpty();
        }
    }
}
