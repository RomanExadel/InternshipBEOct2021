using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class TeamDTOValidator : AbstractValidator<TeamDTO>
    {
        public TeamDTOValidator()
        {
            RuleFor(team => team.InternshipId).NotEqual(0);
            RuleFor(team => team.Name).NotEmpty();
        }
    }
}
