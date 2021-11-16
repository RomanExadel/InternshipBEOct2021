using BL.Interfaces;
using DAL.Entities;
using System;

namespace BL.Validators
{
    public class InternshipValidator : IInternshipValidator
    {
        public void ValidateIfInternshipExist(Internship internship)
        {
            if (internship == null)
            {
                throw new ArgumentNullException(nameof(internship), "internship is null");
            }
        }
    }
}
