using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
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

        public async Task<InterviewInviteDTO> CreateInterviewInviteAsync(InterviewInviteDTO inviteDto)
        {
            var invite = _mapper.Map<InterviewInvite>(inviteDto);

            invite = await _unitOfWork.InterviewInvites.CreateAsync(invite);

            return _mapper.Map<InterviewInviteDTO>(invite);
        }

        public async Task DeleteInterviewInviteAsync(int id)
        {
            await _unitOfWork.InterviewInvites.DeleteByIdAsync(id);
        }

        public async Task<List<InterviewInviteDTO>> GetAllInterviewInvitesAsync()
        {
            var invites = await _unitOfWork.InterviewInvites.GetAllAsync();

            return _mapper.Map<List<InterviewInviteDTO>>(invites);
        }

        public async Task<List<InterviewInviteDTO>> GetInterviewInvitesByUserIdAsync(string userId)
        {
            var invites = await _unitOfWork.InterviewInvites.GetAllByUserIdAsync(userId);

            return _mapper.Map<List<InterviewInviteDTO>>(invites);
        }

        public async Task<InterviewInviteDTO> UpdateInterviewInviteAsync(InterviewInviteDTO inviteDto)
        {
            var invite = _mapper.Map<InterviewInvite>(inviteDto);

            invite = await _unitOfWork.InterviewInvites.UpdateAsync(invite);

            return _mapper.Map<InterviewInviteDTO>(invite);
        }
    }
}
