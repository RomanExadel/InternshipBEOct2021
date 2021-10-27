using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ICandidateService
    {
        Task<CandidateDTO> GetCandidateAsync(int id);

        Task<CandidateDTO> CreateCandidateAsync(CandidateDTO newCandidate);

        Task<CandidateDTO> UpdateCandidateAsync(CandidateDTO updatedCandidate);

        Task<List<CandidateDTO>> GetAllByInternshipIdAsync(int internshipId, int itemsCount, int pageNumber);
    }
}
