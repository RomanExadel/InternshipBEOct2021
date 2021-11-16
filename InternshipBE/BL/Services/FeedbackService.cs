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
        private readonly IValidator<Feedback> _validator;

        public FeedbackService(IUnitOfWork unitOfWork, IMapper mapper, IValidator<Feedback> validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<FeedbackDTO> CreateFeedbackAsync(FeedbackDTO newFeedback)
        {
            newFeedback.Id = 0;

            var feedback = _mapper.Map<Feedback>(newFeedback);

            feedback = await _unitOfWork.Feedbacks.CreateAsync(feedback);
            newFeedback = _mapper.Map<FeedbackDTO>(feedback);

            return newFeedback;
        }

        public async Task<List<FeedbackDTO>> GetFeedbacksByCandidateIdAsync(int candidateId)
        {
            var feedbacks = await _unitOfWork.Feedbacks.GetFeedbacksByCandidateIdAsync(candidateId);
            
            return _mapper.Map<List<FeedbackDTO>>(feedbacks);
        }

        public async Task<FeedbackDTO> GetFeedbackByIdAsync(int id)
        {
            var feedback = await _unitOfWork.Feedbacks.GetByIdAsync(id);
            var feedbackDto = _mapper.Map<FeedbackDTO>(feedback);

            _validator.ValidateIfValueExist(feedback);

            return _mapper.Map<FeedbackDTO>(feedback);
        }

        public async Task<FeedbackDTO> UpdateFeedbackAsync(FeedbackDTO updatedFeedback)
        {
            var feedback = _mapper.Map<Feedback>(updatedFeedback);
            
            feedback = await _unitOfWork.Feedbacks.UpdateAsync(feedback);
            updatedFeedback = _mapper.Map<FeedbackDTO>(feedback);

            return updatedFeedback;
        }
    }
}
