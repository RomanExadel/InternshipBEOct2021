using BL.DTOs.CandidateDTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class CandidateDTOValidator : AbstractValidator<CandidateDTO>
    {
        public CandidateDTOValidator()
        {
            RuleFor(candidate => candidate.Id).NotEqual(0);
            RuleFor(candidate => candidate.RegistrationDate).NotEmpty();
            RuleFor(candidate => candidate.Email).NotEmpty();
            RuleFor(candidate => candidate.FirstName).NotEmpty();
            RuleFor(candidate => candidate.LastName).NotEmpty();
            RuleFor(candidate => candidate.Location).NotEmpty();
            RuleFor(candidate => candidate.Phone).NotEmpty();
            RuleFor(candidate => candidate.Skype).NotEmpty();
            RuleFor(candidate => candidate.StackType).NotEmpty();
            RuleFor(candidate => candidate.EnglishLevelType).NotEmpty();
            RuleFor(candidate => candidate.Education).NotEmpty();
            RuleFor(candidate => candidate.Links).NotEmpty();
            RuleFor(candidate => candidate.OtherInfo).NotEmpty();
            RuleFor(candidate => candidate.PrimarySkill).NotEmpty();
            RuleFor(candidate => candidate.CurrentJob).NotEmpty();
            RuleFor(candidate => candidate.ProfessionalCertificates).NotEmpty();
            RuleFor(candidate => candidate.IsPlanningToJoin).NotEmpty();
            RuleFor(candidate => candidate.TestTaskEvaluation).NotEmpty();
            RuleFor(candidate => candidate.StackType).NotEmpty();
            RuleFor(candidate => candidate.BestContactTime).NotEmpty();            
            RuleFor(candidate => candidate.InternshipId).NotEmpty();
            RuleFor(candidate => candidate.LanguageType).NotEmpty();
        }
    }
}
