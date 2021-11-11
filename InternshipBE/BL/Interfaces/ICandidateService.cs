using BL.DTOs.CandidateDTOs;
using BL.SearchModels;
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

		Task<List<CandidateDTO>> GetCandidatesByInternshipIdAsync(int internshipId, int pageSize, int pageNumber, string sortBy, bool desc, CandidateFilterModelDTO filterBy);

		Task<CandidateDTO> UpdateCandidateStatusByIdAsync(int id, CandidateStatusType type);

		Task<List<CandidateDTO>> SearchAsync(CandidateSearchModel searchModel);
	}
}
