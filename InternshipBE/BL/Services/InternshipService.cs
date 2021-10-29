using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
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

            await _unitOfWork.SaveAsync();

            return _mapper.Map<InternshipDTO>(internship);
        }

<<<<<<< HEAD
<<<<<<< HEAD
        public async Task<List<InternshipDTO>> GetAllInternshipsPartialAsync(int itemsCount, int pageNumber)
        {
            var internships = await _unitOfWork.Internships.GetAllInternshipsPartialAsync(itemsCount, pageNumber);
=======
        public async Task<List<InternshipDTO>> GetAllInternshipAsync()
        {
            var internships = await _unitOfWork.Internships.GetAllAsync();
>>>>>>> 6b6dd06 (Implement Internship service and controller. Implement API for Create, Update, Get one and Get all internships.)
=======
        public async Task<List<InternshipDTO>> GetAllInternshipsPartialAsync(int itemsCount, int pageNumber)
        {
            var internships = await _unitOfWork.Internships.GetAllInternshipsPartialAsync(itemsCount, pageNumber);
>>>>>>> 955ab32 (Delete Useless DTO, Fixed Problems)
            return _mapper.Map<List<InternshipDTO>>(internships);
        }

        public async Task<InternshipDTO> GetInternshipAsync(int id)
        {
            var internship = await _unitOfWork.Internships.GetByIdAsync(id);
            return _mapper.Map<InternshipDTO>(internship);
        }

        public async Task<InternshipDTO> UpdateInternshipAsync(InternshipDTO newInternship)
        {
            var mappedInternship = _mapper.Map<Internship>(newInternship);
            var updatedInternship = await _unitOfWork.Internships.UpdateAsync(mappedInternship);

            await _unitOfWork.SaveAsync();

            return _mapper.Map<InternshipDTO>(updatedInternship);

        }
    }
}
