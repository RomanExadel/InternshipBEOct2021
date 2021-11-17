using AutoMapper;
using BL.DTOs.InternshipDTOs;
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
        private readonly IValidator<Internship> _validator;

        public InternshipService(IUnitOfWork unitOfWork, IMapper mapper, IValidator<Internship> validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<UpdateInternshipDTO> CreateInternshipAsync(CreateInternshipDTO newInternship)
        {
            var mappedInternship = _mapper.Map<Internship>(newInternship);
            var internship = await _unitOfWork.Internships.CreateAsync(mappedInternship);

            return _mapper.Map<UpdateInternshipDTO>(internship);
        }

        public async Task<List<GetInternshipDTO>> GetInternshipsAsync(int pageSize, int pageNumber)
        {
            var internships = await _unitOfWork.Internships.GetInternshipsAsync(pageSize, pageNumber);
            var internshipDtos = _mapper.Map<List<GetInternshipDTO>>(internships);

            return internshipDtos;
        }

        public async Task<GetInternshipDTO> GetInternshipByIdAsync(int id)
        {
            var internship = await _unitOfWork.Internships.GetByIdAsync(id);

            _validator.ValidateIfValueExist(internship);

            var internshipDto = _mapper.Map<GetInternshipDTO>(internship);

            return internshipDto;
        }

        public async Task<UpdateInternshipDTO> UpdateInternshipAsync(UpdateInternshipDTO newInternship)
        {
            var mappedInternship = _mapper.Map<Internship>(newInternship);
            var updatedInternship = await _unitOfWork.Internships.UpdateAsync(mappedInternship);

            return _mapper.Map<UpdateInternshipDTO>(updatedInternship);
        }
    }
}
