using BL.Interfaces;
using DAL.Entities;
using System;

namespace BL.Validators
{
    public class CandidateValidator : ICandidateValidator
    {
        public void ValidateIfCandidateExist(Candidate candidate)
        {
            if (candidate == null)
            {
                throw new ArgumentNullException(nameof(candidate), "candidate is null");
            }
        }
    }
}
