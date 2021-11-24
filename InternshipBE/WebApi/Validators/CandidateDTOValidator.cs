using BL.DTOs.CandidateDTOs;
using FluentValidation;

namespace WebApi.Validators
{
    public class CandidateDTOValidator : AbstractValidator<CandidateDTO>
    {
        public CandidateDTOValidator()
        {
        }
    }
}
