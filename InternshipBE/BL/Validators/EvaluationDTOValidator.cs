using BL.DTOs;
using FluentValidation;

namespace BL.Validators
{
    public class EvaluationDTOValidator : AbstractValidator<EvaluationDTO>
    {
        public EvaluationDTOValidator()
        {
            RuleFor(evaluation => evaluation.Id).NotEqual(0).WithMessage(x => $"The Id {x.Id} is not valid");
            RuleFor(evaluation => evaluation.SkillId).NotEqual(0).WithMessage(x => $"The SkillId {x.SkillId} is not valid");
            RuleFor(evaluation => evaluation.FeedbackId).NotEqual(0).WithMessage(x => $"The FeedbackId {x.FeedbackId} is not valid");
            RuleFor(evaluation => evaluation.Value).NotEqual(0).WithMessage(x => $"The Value {x.Value} is not valid");
            RuleFor(evaluation => evaluation.Skill).NotEmpty().WithMessage(x => $"The Skill {x.Skill} is not valid");
        }
    }
}
