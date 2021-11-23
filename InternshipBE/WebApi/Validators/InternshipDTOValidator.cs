using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class InternshipDTOValidator : AbstractValidator<InternshipDTO>
    {
        public InternshipDTOValidator()
        {
            RuleFor(internship => internship.Id).NotEqual(0);
            RuleFor(internship => internship.SpreadSheetId).NotEmpty();
            RuleFor(internship => internship.CandidatesCount).NotEqual(0);
            RuleFor(internship => internship.DeclinedCandidatesCount).NotEqual(0);
            RuleFor(internship => internship.AcceptedCandidatesCount).NotEqual(0);
            RuleFor(internship => internship.AbandonedCandidatesCount).NotEqual(0);
            RuleFor(internship => internship.SuccessfullyFinishedCandidatesCount).NotEqual(0);
            RuleFor(internship => internship.TeamsCount).NotEqual(0);
            RuleFor(internship => internship.Name).NotEmpty();
            RuleFor(internship => internship.StartDate).NotEmpty();
            RuleFor(internship => internship.EndDate).NotEmpty();
            RuleFor(internship => internship.Requirements).NotEmpty();
            RuleFor(internship => internship.MaxCandidateCount).NotEqual(0);
            RuleFor(internship => internship.RegistrationStartDate).NotEmpty();
            RuleFor(internship => internship.RegistrationFinishDate).NotEmpty();
            RuleFor(internship => internship.LanguageType).NotEmpty();
            RuleFor(internship => internship.InternshipStatusType).NotEmpty();
            RuleFor(internship => internship.ImageLink).NotEmpty();
            RuleFor(internship => internship.InternshipStacks).NotEmpty();
            RuleFor(internship => internship.Locations).NotEmpty();
            RuleFor(internship => internship.Teams).NotNull();
            RuleFor(internship => internship.Users).NotNull();
        }
    }
}
