﻿using BL.DTOs.CandidateDTOs;
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

		Task<List<CandidateDTO>> GetCandidatesByInternshipIdAsync(int internshipId, int pageSize, int pageNumber);

		Task<CandidateDTO> UpdateCandidateStatusByIdAsync(int id, CandidateStatusType type);

		List<CandidateDTO> Search(CandidateSearchModel searchModel);
	}
}
