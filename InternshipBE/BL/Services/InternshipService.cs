using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class InternshipService : IInternshipService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly AbstractValidator<InternshipDTO> _validations;

        public InternshipService(IUnitOfWork unitOfWork, IMapper mapper, AbstractValidator<InternshipDTO> validations)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validations = validations;
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

            return _mapper.Map<List<InternshipDTO>>(internships);
        }

        public async Task<InternshipDTO> GetInternshipByIdAsync(int id)
        {
            var internship = await _unitOfWork.Internships.GetByIdAsync(id);

            return _mapper.Map<InternshipDTO>(internship);
        }

        public async Task<InternshipDTO> UpdateInternshipAsync(InternshipDTO newInternship)
        {
            await _validations.ValidateAndThrowAsync(newInternship);

            var mappedInternship = _mapper.Map<Internship>(newInternship);

            var updatedInternship = await _unitOfWork.Internships.UpdateAsync(mappedInternship);

            return _mapper.Map<InternshipDTO>(updatedInternship);
        }
    }
}