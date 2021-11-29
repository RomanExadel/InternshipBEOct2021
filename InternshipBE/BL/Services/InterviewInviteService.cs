using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class InterviewInviteService : IInterviewInviteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InterviewInviteService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<InterviewInviteDTO>> GetAllInterviewInvitesAsync()
        {
            var invites = await _unitOfWork.InterviewInvites.GetAllAsync();

            return _mapper.Map<List<InterviewInviteDTO>>(invites);
        }
    }
}
