using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class InternshipService : IInternshipService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InternshipService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<InternshipDTO> CreateInternshipAsync(InternshipDTO newInternship)
        {
            var mappedInternship = _mapper.Map<Internship>(newInternship);

            var internship = await _unitOfWork.Internships.CreateAsync(mappedInternship);

            return _mapper.Map<InternshipDTO>(internship);
        }

        public async Task<List<InternshipDTO>> GetInternshipsAsync(int pageSize, int pageNumber)
        {
            var internships = await _unitOfWork.Internships.GetInternshipsAsync(pageSize, pageNumber);
            var internshipDtos = _mapper.Map<List<InternshipDTO>>(internships);

            return internshipDtos;
        }

        public async Task<InternshipDTO> GetInternshipByIdAsync(int id)
        {
            var internship = await _unitOfWork.Internships.GetByIdAsync(id);
            var internshipDto = _mapper.Map<InternshipDTO>(internship);

            return internshipDto;
        }

        public async Task<InternshipDTO> UpdateInternshipAsync(InternshipDTO newInternship)
        {
            var mappedInternship = _mapper.Map<Internship>(newInternship);
            var updatedInternship = await _unitOfWork.Internships.UpdateAsync(mappedInternship);

            return _mapper.Map<InternshipDTO>(updatedInternship);
        }
    }
}
