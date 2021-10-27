using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class CandidateService : ICandidateService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public CandidateService(IUnitOfWork uow, IMapper mapper)
        {
            _unitOfWork = uow;
            _mapper = mapper;
        }

        public async Task<CandidateDTO> GetCandidateAsync(int id)
        {
            var candidate = await _unitOfWork.Candidates.GetByIdAsync(id);

            return _mapper.Map<CandidateDTO>(candidate);
        }

        public async Task<CandidateDTO> CreateCandidateAsync(CandidateDTO newCandidate)
        {
            var mappedCandidate = _mapper.Map<Candidate>(newCandidate);
            var candidate = await _unitOfWork.Candidates.CreateAsync(mappedCandidate);

            await _unitOfWork.Save();

            return _mapper.Map<CandidateDTO>(candidate);
        }

        public async Task<CandidateDTO> UpdateCandidateAsync(CandidateDTO candidate)
        {
            var mappedCandidate = _mapper.Map<Candidate>(candidate);
            var updatedCandidate = await _unitOfWork.Candidates.UpdateAsync(mappedCandidate);

            await _unitOfWork.Save();

            return _mapper.Map<CandidateDTO>(updatedCandidate);
        }

        public async Task<List<CandidateDTO>> GetAllByInternshipIdAsync(int internshipId, int itemsCount, int pageNumber)
        {
            var candidates = await _unitOfWork.Candidates.GetAllByInternshipIdAsync(internshipId, itemsCount, pageNumber);

            return _mapper.Map<List<CandidateDTO>>(candidates);
        }
    }
}
