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
        private readonly IInternshipLanguagesService _serviceInternshipLanguages;
        private readonly IInternshipStackService _serviceInternshipStack;
        private readonly ITeamService _serviceTeam;

        public InternshipService(IUnitOfWork unitOfWork, IMapper mapper, IInternshipLanguagesService serviceInternshipLanguages,
            IInternshipStackService serviceInternshipStack, ITeamService serviceTeam)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _serviceInternshipLanguages = serviceInternshipLanguages;
            _serviceInternshipStack = serviceInternshipStack;
            _serviceTeam = serviceTeam;
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

            return _mapper.Map<InternshipDTO>(internship);
        }

        public async Task<InternshipDTO> UpdateInternshipAsync(InternshipDTO newInternship)
        {
            var mappedInternship = _mapper.Map<Internship>(newInternship);

            var oldInternship = await _unitOfWork.Internships.GetByIdAsync(newInternship.Id);

            mappedInternship = await _serviceInternshipLanguages.CreateOrDeleteLanguages(oldInternship, mappedInternship);
            mappedInternship = await _serviceInternshipStack.CreateOrDeleteStacksAsync(oldInternship, mappedInternship);
            mappedInternship = await _serviceTeam.CreateOrDeleteTeamsAsync(oldInternship, mappedInternship);

            var updatedInternship = await _unitOfWork.Internships.UpdateAsync(mappedInternship);

            return _mapper.Map<InternshipDTO>(updatedInternship);
        }
    }
}