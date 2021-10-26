using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ICandidateService
    {
        Task<CandidateDTO> GetCandidate(int id);

        Task<CandidateDTO> UpdateCandidate(CandidateDTO newCandidate);

        Task<List<CandidateDTO>> GetCandidates(int count, int offset, int internshipId);
    }
}
