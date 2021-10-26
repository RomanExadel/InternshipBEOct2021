using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<CandidateDTO> GetCandidate(int id)
        {
            var candidateEntity = await _uow.Candidates.GetByIdAsync(id);

            return _mapper.Map<CandidateDTO>(candidateEntity);
        }

        public async Task<CandidateDTO> UpdateCandidate(CandidateDTO updatedCandidate)
        {
            var mappedCandidate = _mapper.Map<Candidate>(updatedCandidate);
            var resultCandidate = await _uow.Candidates.UpdateAsync(mappedCandidate);

            return _mapper.Map<CandidateDTO>(resultCandidate);
        }

        public async Task<List<CandidateDTO>> GetCandidates(int count, int offset, int internshipId)
        {
            var internship = await _uow.Internships.GetByIdAsync(internshipId);
            var candidates = internship.Candidate.Skip(offset * count).Take(count);

            return _mapper.Map<List<CandidateDTO>>(candidates);
        }
    }
}
