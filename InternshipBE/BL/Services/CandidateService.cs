using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Entities.Filtering;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CandidateService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
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

        public async Task<List<CandidateDTO>> GetCandidatesByInternshipIdAsync(int internshipId, int pageSize, int pageNumber, CandidateFilterModel filterBy, string sortBy, bool desc)
        {
            var candidates = await _unitOfWork.Candidates.GetCandidatesByInternshipIdAsync(internshipId, pageSize, pageNumber, filterBy, sortBy, desc);

            return _mapper.Map<List<CandidateDTO>>(candidates);
        }

        public async Task<List<CandidateDTO>> UpdateCandidateStatusByIdAsync(List<int> candidatesId, CandidateStatusType type, string userName)
        {
            var candidates = await _unitOfWork.Candidates.GetCandidatesListByIdAsync(candidatesId);

            var users = new List<User> { await _userManager.FindByNameAsync(userName) };

            candidates.ForEach(x => x.Users.ToList().Remove(users[0]));

            candidates.ForEach(x => x.Users.Add(users[0]));

            candidates.ForEach(x => x.StatusType = type);

            var updatedCandidates = await _unitOfWork.Candidates.BulkUpdateAsync(candidates);

            return _mapper.Map<List<CandidateDTO>>(updatedCandidates);
        }

        public async Task<List<CandidateDTO>> SearchByInternshipIdAsync(CandidateDTO searchModel)
        {
            var query = await _unitOfWork.Candidates.SearchCandidatesAsync(searchModel.Skip, searchModel.Take, searchModel.SearchText, searchModel.SortBy, searchModel.IsDesc, searchModel.InternshipId);

            return _mapper.Map<List<CandidateDTO>>(query);
        }
    }
}