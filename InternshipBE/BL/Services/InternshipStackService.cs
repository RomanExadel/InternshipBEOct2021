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

        public async Task<InternshipStackDTO> CreateInternshipStackAsync(InternshipStackDTO internshipStackDto)
        {
            var internshipStack = _mapper.Map<InternshipStack>(internshipStackDto);

            internshipStack = await _unitOfWork.InternshipStacks.CreateAsync(internshipStack);
            
            await _unitOfWork.SaveAsync();

            return _mapper.Map<InternshipStackDTO>(internshipStack);
        }

        public async Task<List<InternshipStackDTO>> GetInternshipStacksByInternshipIdAsync(int internshipId)
        {
            var internshipStacks = await _unitOfWork.InternshipStacks.GetAllByInternshipIdAsync(internshipId);
            var internshipStacksDtos = _mapper.Map<List<InternshipStackDTO>>(internshipStacks);

            return internshipStacksDtos;
        }
        
        public async Task<List<InternshipStackDTO>> GetInternshipStacksAsync()
        {
            var internshipStacks = await _unitOfWork.InternshipStacks.GetAllAsync();
            var internshipStacksDtos = _mapper.Map<List<InternshipStackDTO>>(internshipStacks);

            return internshipStacksDtos;
        }
        
        public async Task<InternshipStackDTO> UpdateInternshipStackAsync(InternshipStackDTO internshipStackDto)
        {
            var internshipStack = _mapper.Map<InternshipStack>(internshipStackDto);

            internshipStack = await _unitOfWork.InternshipStacks.UpdateAsync(internshipStack);
            
            await _unitOfWork.SaveAsync();

            return _mapper.Map<InternshipStackDTO>(internshipStack);
        }
    }
}
