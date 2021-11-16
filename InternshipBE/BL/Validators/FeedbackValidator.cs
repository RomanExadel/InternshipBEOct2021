using BL.Interfaces;
using DAL.Entities;
using System;

namespace BL.Validators
{
    public class FeedbackValidator : IFeedbackValidator
    {
        public void ValidateIfFeedbackExist(Feedback feedback)
        {
            if (feedback == null)
            {
                throw new ArgumentNullException(nameof(feedback), "feedback is null");
            }
        }
    }
}