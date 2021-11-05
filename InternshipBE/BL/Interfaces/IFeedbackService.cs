using BL.DTOs;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IFeedbackService
    {
        Task<FeedbackDTO> GetFeedbackByIdAsync(int id);

        Task<FeedbackDTO> CreateFeedbackAsync(FeedbackDTO newFeedback);

        Task<FeedbackDTO> UpdateFeedbackAsync(FeedbackDTO updatedFeedback);
    }
}
