using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class CountryDTOValidator : AbstractValidator<CountryDTO>
    {
        public CountryDTOValidator()
        {
            RuleFor(country => country.Name).NotEmpty();
        }
    }
}
