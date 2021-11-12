using AutoMapper;
using BL.DTOs.CandidateDTOs;
using BL.Interfaces;
using BL.SearchModels;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<CandidateDTO>> GetCandidatesByInternshipIdAsync(int internshipId, int pageSize, int pageNumber, string sortBy, bool desc, CandidateFilterModelDTO filterBy)
        {
            var candidates = await _unitOfWork.Candidates.GetCandidatesByInternshipIdAsync(internshipId, pageSize, pageNumber);

            if (sortBy != null)
            {
                candidates = SortCandidates(candidates, sortBy, desc);
            }

            if (filterBy != null)
            {
                candidates = FilterCandidates(candidates, filterBy);
            }

            return _mapper.Map<List<CandidateDTO>>(candidates);
        }

        public async Task<CandidateDTO> UpdateCandidateStatusByIdAsync(int id, CandidateStatusType type)
        {
            var candidate = await _unitOfWork.Candidates.GetByIdAsync(id);
            candidate.StatusType = type;
            var updatedCandidate = await _unitOfWork.Candidates.UpdateAsync(candidate);

            return _mapper.Map<CandidateDTO>(updatedCandidate);
        }

        public async Task<List<CandidateDTO>> SearchAsync(CandidateSearchModel searchModel)
        {
            var query = _unitOfWork.Candidates.GetAllCandidates();
            var searchQuery = searchModel.Find(query);

            return _mapper.Map<List<CandidateDTO>>(await searchQuery.Body.ToListAsync());
        }

        private List<Candidate> SortCandidates(List<Candidate> candidates, string sortBy, bool desc)
        {
            var propertyInfo = typeof(Candidate).GetProperty(sortBy);

            if (desc)
                candidates = candidates.AsEnumerable<Candidate>().OrderByDescending(c => propertyInfo.GetValue(c, null)).ToList();

            else
                candidates = candidates.AsEnumerable<Candidate>().OrderBy(c => propertyInfo.GetValue(c, null)).ToList();

            return candidates;
        }

        private List<Candidate> FilterCandidates(List<Candidate> candidates, CandidateFilterModelDTO filterBy)
        {
            var _candidates = candidates.AsQueryable();
            if (!string.IsNullOrEmpty(filterBy.Location))
                _candidates = _candidates.Where(c => c.Location == filterBy.Location);
            if (filterBy.StackType.HasValue)
                _candidates = _candidates.Where(c => c.StackType == filterBy.StackType);
            if (filterBy.StatusType.HasValue)
                _candidates = _candidates.Where(c => c.StatusType == filterBy.StatusType);

            return _candidates.ToList();
        }
    }
}
