using BL.DTOs;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IEvaluationService
    {
        Task<EvaluationDTO> CreateEvaluationAsync(EvaluationDTO evaluationDto);
    }
}
