using AutoMapper;
using BL.DTOs.InternshipStackDTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class InternshipStackService : IInternshipStackService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InternshipStackService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<FullInternshipStackDTO> CreateInternshipStackAsync(CreateInternshipStackDTO internshipStackDto)
        {
            var internshipStack = _mapper.Map<InternshipStack>(internshipStackDto);

            internshipStack = await _unitOfWork.InternshipStacks.CreateAsync(internshipStack);

            return _mapper.Map<FullInternshipStackDTO>(internshipStack);
        }

        public async Task<List<GetInternshipStackDTO>> GetInternshipStacksByInternshipIdAsync(int internshipId)
        {
            var internshipStacks = await _unitOfWork.InternshipStacks.GetAllByInternshipIdAsync(internshipId);
            var internshipStacksDtos = _mapper.Map<List<GetInternshipStackDTO>>(internshipStacks);

            return internshipStacksDtos;
        }
        
        public async Task<FullInternshipStackDTO> UpdateInternshipStackAsync(FullInternshipStackDTO internshipStackDto)
        {
            var internshipStack = _mapper.Map<InternshipStack>(internshipStackDto);

            internshipStack = await _unitOfWork.InternshipStacks.UpdateAsync(internshipStack);

            return _mapper.Map<FullInternshipStackDTO>(internshipStack);
        }
    }
}
