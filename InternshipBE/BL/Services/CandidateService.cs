using AutoMapper;
using BL.DTOs.CandidateDTOs;
using BL.Interfaces;
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

            return _mapper.Map<CandidateDTO>(candidate);
        }

        public async Task<CandidateDTO> UpdateCandidateAsync(CandidateDTO candidate)
        {

            var mappedCandidate = _mapper.Map<Candidate>(candidate);

            var updatedCandidate = await _unitOfWork.Candidates.UpdateAsync(mappedCandidate);

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
                candidates = await FilterCandidates(filterBy);
            }

            return _mapper.Map<List<CandidateDTO>>(candidates);
        }

        public async Task<CandidateDTO> UpdateCandidateStatusByIdAsync(int id, CandidateStatusType type)
        {
            var candidate = await _unitOfWork.Candidates.GetByIdAsync(id);

            candidate.StatusType = type;

            candidate.Users = null;

            var updatedCandidate = await _unitOfWork.Candidates.UpdateAsync(candidate);

            return _mapper.Map<CandidateDTO>(updatedCandidate);
        }

        public async Task<List<CandidateDTO>> SearchByInternshipIdAsync(CandidateDTO searchModel)
        {
            var query = await _unitOfWork.Candidates.SearchCandidatesAsync(searchModel.Skip, searchModel.Take, searchModel.SearchText, searchModel.SortBy, searchModel.IsDesc, searchModel.InternshipId);

            return _mapper.Map<List<CandidateDTO>>(query);
        }

        private List<Candidate> SortCandidates(List<Candidate> candidates, string sortBy, bool desc)
        {
            var propertyInfo = typeof(Candidate).GetProperty(sortBy);

            if (desc)
                candidates = candidates.AsEnumerable().OrderByDescending(c => propertyInfo.GetValue(c, null)).ToList();
            else
                candidates = candidates.AsEnumerable().OrderBy(c => propertyInfo.GetValue(c, null)).ToList();

            return candidates;
        }

        private async Task<List<Candidate>> FilterCandidates(CandidateFilterModelDTO filterBy)
        {
            var _candidates = _unitOfWork.Candidates.GetCandidatesForFIlter();

            if (!string.IsNullOrEmpty(filterBy.Location))
                _candidates = _candidates.Where(c => c.Location == filterBy.Location);
            if (filterBy.StackType.HasValue)
                _candidates = _candidates.Where(c => c.StackType == filterBy.StackType);
            if (filterBy.StatusType.HasValue)
                _candidates = _candidates.Where(c => c.StatusType == filterBy.StatusType);
            if (filterBy.LanguageType.HasValue)
                _candidates = _candidates.Where(c => c.InternshipLanguage == filterBy.LanguageType);

            return await _candidates.ToListAsync();
        }
    }
}