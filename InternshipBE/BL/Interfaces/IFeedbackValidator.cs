using DAL.Entities;

namespace BL.Interfaces
{
    public interface IFeedbackValidator
    {
        public void ValidateIfFeedbackExist(Feedback feedback);
    }
}
