using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class InterviewInviteDTOValidator : AbstractValidator<InterviewInviteDTO>
    {
        public InterviewInviteDTOValidator()
        {
            RuleFor(invite => invite.CandidateId).NotEmpty();
            RuleFor(invite => invite.ContactDate).NotEmpty();
            RuleFor(invite => invite.UserId).NotEmpty();
        }
    }
}
