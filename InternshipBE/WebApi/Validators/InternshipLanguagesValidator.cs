using DAL.Entities;
using FluentValidation;

namespace WebApi.Validators
{
    public class InternshipLanguagesValidator : AbstractValidator<InternshipLanguage>
    {
        public InternshipLanguagesValidator()
        {
            RuleFor(languages => languages.InternshipId).NotEqual(0);
            RuleFor(languages => languages.LanguageType).IsInEnum();
        }
    }
}
