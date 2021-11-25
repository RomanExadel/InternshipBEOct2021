using BL.DTOs.CandidateDTOs;
using DAL.Entities.Filtering;
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

        Task<List<CandidateDTO>> GetCandidatesByInternshipIdAsync(int internshipId, int pageSize, int pageNumber,  CandidateFilterModel filterBy);

        Task<List<CandidateDTO>> UpdateCandidateStatusByIdAsync(List<int> candidatesId, CandidateStatusType type, string userName);

        Task<List<CandidateDTO>> SearchByInternshipIdAsync(CandidateDTO searchModel);
    }
}
