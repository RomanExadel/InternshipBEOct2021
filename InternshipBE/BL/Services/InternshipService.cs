using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Entities.Filtering;
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

        public async Task<InternshipDTO> CreateInternshipAsync(InternshipDTO newInternship)
        {
            var mappedInternship = _mapper.Map<Internship>(newInternship);
            var internship = await _unitOfWork.Internships.CreateAsync(mappedInternship);

            return _mapper.Map<InternshipDTO>(internship);
        }

        public async Task<List<InternshipDTO>> GetInternshipsAsync(int pageSize, int pageNumber, InternshipFilterModel filterBy)
        {
            var internships = await _unitOfWork.Internships.GetInternshipsAsync(pageSize, pageNumber, filterBy);
            
            return _mapper.Map<List<InternshipDTO>>(internships);
        }

        public async Task<InternshipDTO> GetInternshipByIdAsync(int id)
        {
            var internship = await _unitOfWork.Internships.GetByIdAsync(id);

            _validator.ValidateIfEntityExist(internship);

            return _mapper.Map<InternshipDTO>(internship);
        }

        public async Task<InternshipDTO> UpdateInternshipAsync(InternshipDTO newInternship)
        {
            var mappedInternship = _mapper.Map<Internship>(newInternship);

            var updatedInternship = await _unitOfWork.Internships.UpdateAsync(mappedInternship);

            return _mapper.Map<InternshipDTO>(updatedInternship);
        }
    }
}