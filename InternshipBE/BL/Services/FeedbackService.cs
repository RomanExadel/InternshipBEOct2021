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
            var feedback = _mapper.Map<Feedback>(newFeedback);

            feedback.Evaluations = null;
            feedback = await _unitOfWork.Feedbacks.CreateAsync(feedback);

            var evaluations = new List<Evaluation>();
            evaluations.AddRange(_mapper.Map<List<Evaluation>>(newFeedback.Evaluations));

            feedback.Evaluations = evaluations;
            feedback = await _unitOfWork.Feedbacks.UpdateAsync(feedback);

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

            _validator.ValidateIfEntityExists(feedback);

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