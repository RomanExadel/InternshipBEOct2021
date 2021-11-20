using BL.Interfaces;
using DAL.Entities;
using System.Collections.Generic;

namespace BL.Validators
{
    public class FeedbackValidator : Validator<Feedback>, IFeedbackValidator
    {
        public bool AreEvaluationsExist(ICollection<Evaluation> evaluations)
        {
            return  evaluations == null || evaluations.Count == 0 ? false : true;
        }
    }
}