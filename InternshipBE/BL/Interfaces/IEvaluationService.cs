using BL.DTOs.EvaluationDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IEvaluationService
    {
        Task<CreateEvaluationDTO> CreateEvaluationAsync(CreateEvaluationDTO createEvaluationDto);

        Task<List<GetEvaluationDTO>> GetEvaluationsByFeedbackId(int feedbackId);

        Task<FullEvaluationDTO> UpdateEvaluationAsync(FullEvaluationDTO fullEvaluationDto);
    }
}
