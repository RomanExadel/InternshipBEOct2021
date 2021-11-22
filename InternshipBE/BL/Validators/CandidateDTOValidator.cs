using BL.DTOs.CandidateDTOs;
using FluentValidation;

namespace BL.Validators
{
    public class CandidateDTOValidator : AbstractValidator<CandidateDTO>
    {
        public CandidateDTOValidator()
        {
            RuleFor(candidate => candidate.Id).NotEqual(0).WithMessage(x => $"The Id {x.Id} is not valid");
            RuleFor(candidate => candidate.RegistrationDate).NotEmpty().WithMessage(x => $"The RegistrationDate {x.RegistrationDate} is not valid");
            RuleFor(candidate => candidate.Email).NotEmpty().WithMessage(x => $"The Email {x.Email} is not valid");
            RuleFor(candidate => candidate.FirstName).NotEmpty().WithMessage(x => $"The FirstName {x.FirstName} is not valid");
            RuleFor(candidate => candidate.LastName).NotEmpty().WithMessage(x => $"The LastName {x.LastName} is not valid");
            RuleFor(candidate => candidate.Location).NotEmpty().WithMessage(x => $"The Location {x.Location} is not valid");
            RuleFor(candidate => candidate.Phone).NotEmpty().WithMessage(x => $"The Phone {x.Phone} is not valid");
            RuleFor(candidate => candidate.Skype).NotEmpty().WithMessage(x => $"The Skype {x.Skype} is not valid");
            RuleFor(candidate => candidate.StackType).NotEmpty().WithMessage(x => $"The StackType {x.StackType} is not valid");
            RuleFor(candidate => candidate.EnglishLevelType).NotEmpty().WithMessage(x => $"The EnglishLevelType {x.EnglishLevelType} is not valid");
            RuleFor(candidate => candidate.Education).NotEmpty().WithMessage(x => $"The Education {x.Education} is not valid");
            RuleFor(candidate => candidate.Links).NotEmpty().WithMessage(x => $"The Links {x.Links} is not valid");
            RuleFor(candidate => candidate.OtherInfo).NotEmpty().WithMessage(x => $"The OtherInfo {x.OtherInfo} is not valid");
            RuleFor(candidate => candidate.PrimarySkill).NotEmpty().WithMessage(x => $"The PrimarySkill {x.PrimarySkill} is not valid");
            RuleFor(candidate => candidate.CurrentJob).NotEmpty().WithMessage(x => $"The CurrentJob {x.CurrentJob} is not valid");
            RuleFor(candidate => candidate.ProfessionalCertificates).NotEmpty().WithMessage(x => $"The ProfessionalCertificates {x.ProfessionalCertificates} is not valid");
            RuleFor(candidate => candidate.IsPlanningToJoin).NotEmpty().WithMessage(x => $"The IsPlanningToJoin {x.IsPlanningToJoin} is not valid");
            RuleFor(candidate => candidate.TestTaskEvaluation).NotEmpty().WithMessage(x => $"The TestTaskEvaluation {x.TestTaskEvaluation} is not valid");
            RuleFor(candidate => candidate.StackType).NotEmpty().WithMessage(x => $"The StackType {x.StackType} is not valid");
            RuleFor(candidate => candidate.BestContactTime).NotEmpty().WithMessage(x => $"The BestContactTime {x.BestContactTime} is not valid");            
            RuleFor(candidate => candidate.InternshipId).NotEmpty().WithMessage(x => $"The InternshipId {x.InternshipId} is not valid");
            RuleFor(candidate => candidate.LanguageType).NotEmpty().WithMessage(x => $"The LanguageType {x.LanguageType} is not valid");
        }
    }
}
