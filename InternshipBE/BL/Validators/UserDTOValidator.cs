using BL.DTOs;
using FluentValidation;

namespace BL.Validators
{
    public class UserDTOValidator : AbstractValidator<UserDTO>
    {
        public UserDTOValidator()
        {
            RuleFor(user => user.Id).NotNull().NotEmpty();
        }
    }
}
