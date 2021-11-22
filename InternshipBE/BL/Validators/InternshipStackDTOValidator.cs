using BL.DTOs;
using FluentValidation;

namespace BL.Validators
{
    public class InternshipStackDTOValidator : AbstractValidator<InternshipStackDTO>
    {
        public InternshipStackDTOValidator()
        {
            RuleFor(internshipStack => internshipStack.Id).NotEqual(0).WithMessage(x => $"The Id {x.Id} is not valid");
            RuleFor(internshipStack => internshipStack.InternshipId).NotEqual(0).WithMessage(x => $"The InternshipId {x.InternshipId} is not valid");
            RuleFor(internshipStack => internshipStack.TechnologyStackType).NotEmpty().WithMessage(x => $"The TechnologyStackType {x.TechnologyStackType} is not valid");
        }
    }
}
