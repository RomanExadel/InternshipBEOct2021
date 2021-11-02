using BL.DTOs;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ICandidateService
    {
        Task<CandidateDTO> GetCandidateByIdAsync(int id);

        Task<CandidateDTO> CreateCandidateAsync(CandidateDTO newCandidate);

        Task<CandidateDTO> UpdateCandidateAsync(CandidateDTO updatedCandidate);

        Task<List<CandidateDTO>> GetCandidatesByInternshipIdAsync(int internshipId, int pageSize, int pageNumber);

        Task<CandidateDTO> ChangeCandidateStatus(StatusType type, int Id);
    }
}
