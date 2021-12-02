using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class TeamService : ITeamService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TeamService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Internship> CreateOrDeleteTeamsAsync(Internship oldInternship, Internship newInternship)
        {
            return await _unitOfWork.Teams.CreateOrDeleteTeamsAsync(oldInternship, newInternship);
        }

        public async Task<TeamDTO> CreateTeamByInternshipIdAsync(TeamDTO teamDTO)
        {
            var mappedTeam = _mapper.Map<Team>(teamDTO);

            var team = await _unitOfWork.Teams.CreateAsync(mappedTeam);

            return _mapper.Map<TeamDTO>(team);
        }

        public async Task<List<TeamDTO>> GetTeamsByInternshipIdAsync(int internshipId)
        {
            var teams = await _unitOfWork.Teams.GetTeamsByInternshipIdAsync(internshipId);

            return _mapper.Map<List<TeamDTO>>(teams);
        }
    }
}
