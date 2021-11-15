using AutoMapper;
using BL.DTOs.FeedbackDTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FeedbackService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<FullGetFeedbackDTO> CreateFeedbackAsync(CreateFeedbackDTO newFeedback)
        {
            var feedback = await _unitOfWork.Feedbacks.CreateAsync(_mapper.Map<Feedback>(newFeedback));

            return _mapper.Map<FullGetFeedbackDTO>(feedback);
        }

        public async Task<List<FullGetFeedbackDTO>> GetFeedbacksByCandidateIdAsync(int candidateId)
        {
            var feedbacks = await _unitOfWork.Feedbacks.GetFeedbacksByCandidateIdAsync(candidateId);
            
            return _mapper.Map<List<FullGetFeedbackDTO>>(feedbacks);
        }

        public async Task<GetFeedbackDTO> GetFeedbackByIdAsync(int id)
        {
            var feedback = await _unitOfWork.Feedbacks.GetByIdAsync(id);

            return _mapper.Map<GetFeedbackDTO>(feedback);
        }

        public async Task<UpdateFeedbackDTO> UpdateFeedbackAsync(UpdateFeedbackDTO updatedFeedback)
        {
            var feedback = await _unitOfWork.Feedbacks.UpdateAsync(_mapper.Map<Feedback>(updatedFeedback));

            return _mapper.Map<UpdateFeedbackDTO>(feedback);
        }
    }
}
