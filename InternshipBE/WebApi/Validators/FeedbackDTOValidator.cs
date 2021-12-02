using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class FeedbackDTOValidator : AbstractValidator<FeedbackDTO>
    {
        public FeedbackDTOValidator()
        {
            RuleFor(feedback => feedback.CandidateId).NotEqual(0);
            //RuleFor(feedback => feedback.User).NotEmpty();
            RuleFor(feedback => feedback.EnglishLevelType).NotEmpty();
            RuleFor(feedback => feedback.Date).NotEmpty();
            RuleFor(feedback => feedback.Description).NotEmpty();
        }
    }
}
