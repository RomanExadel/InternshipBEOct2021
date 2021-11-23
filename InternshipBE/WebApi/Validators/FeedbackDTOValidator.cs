using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class FeedbackDTOValidator : AbstractValidator<FeedbackDTO>
    {
        public FeedbackDTOValidator()
        {
            RuleFor(feedback => feedback.Id).NotEqual(0);
            RuleFor(feedback => feedback.CandidateId).NotEqual(0);
            RuleFor(feedback => feedback.UserId).NotEmpty();
            RuleFor(feedback => feedback.EnglishLevelType).NotEmpty();
            RuleFor(feedback => feedback.Date).NotEmpty();
            RuleFor(feedback => feedback.Description).NotEmpty();
            RuleFor(feedback => feedback.Evaluations).NotNull();
        }
    }
}
