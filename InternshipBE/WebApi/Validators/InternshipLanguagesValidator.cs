using DAL.Entities;
using FluentValidation;

namespace WebApi.Validators
{
    public class InternshipLanguagesValidator : AbstractValidator<InternshipLanguage>
    {
        public InternshipLanguagesValidator()
        {
            RuleFor(languages => languages.InternshipId).ExclusiveBetween(0, int.MaxValue);
            RuleFor(languages => languages.LanguageType).IsInEnum();
        }
    }
}
