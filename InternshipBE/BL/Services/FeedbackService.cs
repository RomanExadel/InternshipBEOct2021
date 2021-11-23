using AutoMapper;
using BL.DTOs;
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

        public async Task<FeedbackDTO> CreateFeedbackAsync(FeedbackDTO newFeedback)
        {
            var feedback = _mapper.Map<Feedback>(newFeedback);

            feedback = await _unitOfWork.Feedbacks.CreateAsync(feedback);

            return _mapper.Map<FeedbackDTO>(feedback);
        }

        public async Task<List<FeedbackDTO>> GetFeedbacksByCandidateIdAsync(int candidateId)
        {
            var feedbacks = await _unitOfWork.Feedbacks.GetFeedbacksByCandidateIdAsync(candidateId);

            return _mapper.Map<List<FeedbackDTO>>(feedbacks);
        }

        public async Task<FeedbackDTO> GetFeedbackByIdAsync(int id)
        {
            var feedback = await _unitOfWork.Feedbacks.GetByIdAsync(id);

            return _mapper.Map<FeedbackDTO>(feedback);
        }

        public async Task<FeedbackDTO> UpdateFeedbackAsync(FeedbackDTO updatedFeedback)
        {
            var feedback = _mapper.Map<Feedback>(updatedFeedback);

            feedback = await _unitOfWork.Feedbacks.UpdateAsync(feedback);

            return _mapper.Map<FeedbackDTO>(feedback);
        }
    }
}