using AutoMapper;
using BL.DTOs.CandidateDTOs;
using BL.Interfaces;
using BL.SearchModels;
using DAL.Entities;
using DAL.Interfaces;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Services
{
	public class CandidateService : ICandidateService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public CandidateService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<CandidateDTO> GetCandidateByIdAsync(int id)
		{
			var candidate = await _unitOfWork.Candidates.GetByIdAsync(id);

			return _mapper.Map<CandidateDTO>(candidate);
		}

		public async Task<CandidateDTO> CreateCandidateAsync(CandidateDTO newCandidate)
		{
			var mappedCandidate = _mapper.Map<Candidate>(newCandidate);
			var candidate = await _unitOfWork.Candidates.CreateAsync(mappedCandidate);

			await _unitOfWork.SaveAsync();

			return _mapper.Map<CandidateDTO>(candidate);
		}

		public async Task<CandidateDTO> UpdateCandidateAsync(CandidateDTO candidate)
		{
			var mappedCandidate = _mapper.Map<Candidate>(candidate);
			var updatedCandidate = await _unitOfWork.Candidates.UpdateAsync(mappedCandidate);

			await _unitOfWork.SaveAsync();

			return _mapper.Map<CandidateDTO>(updatedCandidate);
		}

		public async Task<List<CandidateDTO>> GetCandidatesByInternshipIdAsync(int internshipId, int pageSize, int pageNumber)
		{
			var candidates = await _unitOfWork.Candidates.GetCandidatesByInternshipIdAsync(internshipId, pageSize, pageNumber);

			return _mapper.Map<List<CandidateDTO>>(candidates);
		}

		public async Task<CandidateDTO> UpdateCandidateStatusByIdAsync(int id, CandidateStatusType type)
		{
			var candidate = await _unitOfWork.Candidates.GetByIdAsync(id);
			candidate.StatusType = type;
			var updatedCandidate = await _unitOfWork.Candidates.UpdateAsync(candidate);

			return _mapper.Map<CandidateDTO>(updatedCandidate);
		}

		public List<CandidateDTO> Search(CandidateSearchModel searchModel)
		{
			var query = _unitOfWork.Candidates.GetAllCandidates();
			var searchQuery = searchModel.Find(query);

			return _mapper.Map<List<CandidateDTO>>(searchQuery.Body.ToList());
		}
	}
}
