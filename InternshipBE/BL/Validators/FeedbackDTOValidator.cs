using BL.DTOs;
using FluentValidation;

namespace BL.Validators
{
    public class FeedbackDTOValidator : AbstractValidator<FeedbackDTO>
    {
        public FeedbackDTOValidator()
        {
            RuleFor(feedback => feedback.Id).NotEqual(0).WithMessage(x => $"The Id {x.Id} is not valid");
            RuleFor(feedback => feedback.CandidateId).NotEqual(0).WithMessage(x => $"The CandidateId {x.CandidateId} is not valid");
            RuleFor(feedback => feedback.UserId).NotEmpty().WithMessage(x => $"The UserId {x.UserId} is not valid");
            RuleFor(feedback => feedback.EnglishLevelType).NotEmpty().WithMessage(x => $"The EnglishLevelType {x.EnglishLevelType} is not valid");
            RuleFor(feedback => feedback.Date).NotEmpty().WithMessage(x => $"The Date {x.Date} is not valid");
            RuleFor(feedback => feedback.Description).NotEmpty().WithMessage(x => $"The Description {x.Description} is not valid");
            RuleFor(feedback => feedback.Evaluations).NotNull().WithMessage(x => $"The Evaluations {x.Evaluations} is not valid");
        }
    }
}
