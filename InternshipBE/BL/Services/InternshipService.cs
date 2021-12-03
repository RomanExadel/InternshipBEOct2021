using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Entities.Filtering;
using DAL.Interfaces;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Services
{
    public class InternshipService : IInternshipService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IInternshipLanguagesService _internshipLanguagesService;
        private readonly IInternshipStackService _internshipStackService;
        private readonly ITeamService _teamService;

        public InternshipService(IUnitOfWork unitOfWork, IMapper mapper, IInternshipLanguagesService internshipLanguagesService,
            IInternshipStackService internshipStackService, ITeamService teamService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _internshipLanguagesService = internshipLanguagesService;
            _internshipStackService = internshipStackService;
            _teamService = teamService;
        }

        public async Task<InternshipDTO> CreateInternshipAsync(InternshipDTO newInternship)
        {
            var mappedInternship = _mapper.Map<Internship>(newInternship);
            var internship = await _unitOfWork.Internships.CreateAsync(mappedInternship);

            return _mapper.Map<InternshipDTO>(internship);
        }

        public async Task<List<InternshipDTO>> GetInternshipsAsync(int pageSize, int pageNumber, InternshipFilterModel<string> filterBy)
        {
            var _filterBy = new InternshipFilterModel<int>();

            if (filterBy != null)
                _filterBy = new InternshipFilterModel<int>
                {
                    Locations = filterBy.Locations,
                    LanguageTypes = filterBy.LanguageTypes?.Select(x => (int)Enum.Parse<InternshipLanguageType>(x)).ToList(),
                    InternshipStatusType = (int)Enum.Parse<InternshipStatusType>(filterBy.InternshipStatusType),
                    InternshipStacks = filterBy.InternshipStacks?.Select(x => (int)Enum.Parse<StackType>(x)).ToList(),
                    AttachedUsers = filterBy.AttachedUsers,
                    InternshipYear = filterBy.InternshipYear
                };

            var internships = await _unitOfWork.Internships.GetInternshipsAsync(pageSize, pageNumber, _filterBy);
            
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

            mappedInternship = await _internshipLanguagesService.CreateOrDeleteLanguagesAsync(oldInternship, mappedInternship);
            mappedInternship = await _internshipStackService.CreateOrDeleteStacksAsync(oldInternship, mappedInternship);
            mappedInternship = await _teamService.CreateOrDeleteTeamsAsync(oldInternship, mappedInternship);

            var updatedInternship = await _unitOfWork.Internships.UpdateAsync(mappedInternship);

            return _mapper.Map<InternshipDTO>(updatedInternship);
        }
    }
}