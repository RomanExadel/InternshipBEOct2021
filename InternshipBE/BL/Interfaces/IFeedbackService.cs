using BL.DTOs.FeedbackDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IFeedbackService
    {
        Task<GetFeedbackDTO> GetFeedbackByIdAsync(int id);

        Task<FeedbackDTO> CreateFeedbackAsync(FeedbackDTO newFeedback);

        Task<UpdateFeedbackDTO> UpdateFeedbackAsync(UpdateFeedbackDTO updatedFeedback);

        Task<List<UpdateFeedbackDTO>> GetFeedbacksByCandidateIdAsync(int candidateId);
    }
}