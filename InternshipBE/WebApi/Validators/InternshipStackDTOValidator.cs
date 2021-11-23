using BL.DTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class InternshipStackDTOValidator : AbstractValidator<InternshipStackDTO>
    {
        public InternshipStackDTOValidator()
        {
            RuleFor(internshipStack => internshipStack.InternshipId).NotEqual(0);
            RuleFor(internshipStack => internshipStack.TechnologyStackType).NotEmpty();
        }
    }
}
