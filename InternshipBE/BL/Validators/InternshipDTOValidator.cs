using BL.DTOs;
using FluentValidation;

namespace BL.Validators
{
    public class InternshipDTOValidator : AbstractValidator<InternshipDTO>
    {
        public InternshipDTOValidator()
        {
            RuleFor(internship => internship.Id).NotEqual(0).WithMessage(x => $"The Id {x.Id} is not valid");
            RuleFor(internship => internship.SpreadSheetId).NotEmpty().WithMessage(x => $"The SpreadSheetId {x.SpreadSheetId} is not valid");
            RuleFor(internship => internship.CandidatesCount).NotEqual(0).WithMessage(x => $"The CandidatesCount {x.CandidatesCount} is not valid");
            RuleFor(internship => internship.DeclinedCandidatesCount).NotEqual(0).WithMessage(x => $"The DeclinedCandidatesCount {x.DeclinedCandidatesCount} is not valid");
            RuleFor(internship => internship.AcceptedCandidatesCount).NotEqual(0).WithMessage(x => $"The AcceptedCandidatesCount {x.AcceptedCandidatesCount} is not valid");
            RuleFor(internship => internship.AbandonedCandidatesCount).NotEqual(0).WithMessage(x => $"The AbandonedCandidatesCount {x.AbandonedCandidatesCount} is not valid");
            RuleFor(internship => internship.SuccessfullyFinishedCandidatesCount).NotEqual(0).WithMessage(x => $"The SuccessfullyFinishedCandidatesCount {x.SuccessfullyFinishedCandidatesCount} is not valid");
            RuleFor(internship => internship.TeamsCount).NotEqual(0).WithMessage(x => $"The TeamsCount {x.TeamsCount} is not valid");
            RuleFor(internship => internship.Name).NotEmpty().WithMessage(x => $"The Name {x.Name} is not valid");
            RuleFor(internship => internship.StartDate).NotEmpty().WithMessage(x => $"The StartDate {x.StartDate} is not valid");
            RuleFor(internship => internship.EndDate).NotEmpty().WithMessage(x => $"The EndDate {x.EndDate} is not valid");
            RuleFor(internship => internship.Requirements).NotEmpty().WithMessage(x => $"The Requirements {x.Requirements} is not valid");
            RuleFor(internship => internship.MaxCandidateCount).NotEqual(0).WithMessage(x => $"The MaxCandidateCount {x.MaxCandidateCount} is not valid");
            RuleFor(internship => internship.RegistrationStartDate).NotEmpty().WithMessage(x => $"The RegistrationStartDate {x.RegistrationStartDate} is not valid");
            RuleFor(internship => internship.RegistrationFinishDate).NotEmpty().WithMessage(x => $"The RegistrationFinishDate {x.RegistrationFinishDate} is not valid");
            RuleFor(internship => internship.LanguageType).NotEmpty().WithMessage(x => $"The LanguageType {x.LanguageType} is not valid");
            RuleFor(internship => internship.InternshipStatusType).NotEmpty().WithMessage(x => $"The InternshipStatusType {x.InternshipStatusType} is not valid");
            RuleFor(internship => internship.ImageLink).NotEmpty().WithMessage(x => $"The ImageLink {x.ImageLink} is not valid");
            RuleFor(internship => internship.InternshipStacks).NotEmpty().WithMessage(x => $"The InternshipStacks {x.InternshipStacks} is not valid");
            RuleFor(internship => internship.Locations).NotEmpty().WithMessage(x => $"The Locations {x.Locations} is not valid");
            RuleFor(internship => internship.Teams).NotNull().WithMessage(x => $"The Teams {x.Teams} is not valid");
            RuleFor(internship => internship.Users).NotNull().WithMessage(x => $"The Users {x.Users} is not valid");
        }
    }
}
