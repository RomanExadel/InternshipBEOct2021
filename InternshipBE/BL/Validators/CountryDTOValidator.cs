using BL.DTOs;
using FluentValidation;

namespace BL.Validators
{
    public class CountryDTOValidator : AbstractValidator<CountryDTO>
    {
        public CountryDTOValidator()
        {
            RuleFor(country => country.Id).NotEqual(0).WithMessage(x => $"The Id {x.Id} is not valid");
            RuleFor(country => country.Name).NotEmpty().WithMessage(x => $"The Name {x.Name} is not valid");
        }
    }
}
