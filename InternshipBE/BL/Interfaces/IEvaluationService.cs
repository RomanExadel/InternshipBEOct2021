using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IEvaluationService
    {
        Task<EvaluationDTO> CreateEvaluationAsync(EvaluationDTO createEvaluationDto);

        Task<List<EvaluationDTO>> GetEvaluationsByFeedbackIdAsync(int feedbackId);

        Task<EvaluationDTO> UpdateEvaluationAsync(EvaluationDTO fullEvaluationDto);
    }
}
