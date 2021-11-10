using BL.DTOs.FeedbackDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IFeedbackService
    {
        Task<GetFeedbackDTO> GetFeedbackByIdAsync(int id);

        Task<FullGetFeedbackDTO> CreateFeedbackAsync(CreateFeedbackDTO newFeedback);

        Task<UpdateFeedbackDTO> UpdateFeedbackAsync(UpdateFeedbackDTO updatedFeedback);

        Task<List<FullGetFeedbackDTO>> GetFeedbacksByCandidateIdAsync(int candidateId);
    }
}