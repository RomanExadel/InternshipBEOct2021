using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IEvaluationService
    {
        Task<EvaluationDTO> CreateEvaluationAsync(EvaluationDTO evaluationDto);

        Task<List<EvaluationDTO>> GetEvaluationsByFeedbackId(int feedbackId);
    }
}
