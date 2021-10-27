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
        private IUnitOfWork _uow;
        private IMapper _mapper;

        public CandidateService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<CandidateDTO> GetCandidateAsync(int id)
        {
            var candidateEntity = await _uow.Candidates.GetByIdAsync(id);

            return _mapper.Map<CandidateDTO>(candidateEntity);
        }

        public async Task<CandidateDTO> CreateCandidateAsync(CandidateDTO newCandidate)
        {
            var mappedCandidate = _mapper.Map<Candidate>(newCandidate);
            var candidate = await _uow.Candidates.CreateAsync(mappedCandidate);

            await _uow.Save();

            return _mapper.Map<CandidateDTO>(candidate);
        }

        public async Task<CandidateDTO> UpdateCandidateAsync(CandidateDTO updatedCandidate)
        {
            var mappedCandidate = _mapper.Map<Candidate>(updatedCandidate);
            var resultCandidate = await _uow.Candidates.UpdateAsync(mappedCandidate);

            await _uow.Save();

            return _mapper.Map<CandidateDTO>(resultCandidate);
        }

        public async Task<List<CandidateDTO>> GetAllByInternshipIdAsync(int internshipId, int itemsCount, int pageNumber)
        {
            var candidates = await _uow.Candidates.GetAllByInternshipIdAsync(internshipId, itemsCount, pageNumber);

            return _mapper.Map<List<CandidateDTO>>(candidates);
        }
    }
}
