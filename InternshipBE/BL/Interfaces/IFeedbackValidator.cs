using DAL.Entities;
using System.Collections.Generic;

namespace BL.Interfaces
{
    public interface IFeedbackValidator : IValidator<Feedback>
    {
        bool AreEvaluationsExist(ICollection<Evaluation> evaluations);
    }
}
