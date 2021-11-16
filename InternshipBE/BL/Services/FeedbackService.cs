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
        private readonly IFeedbackValidator _feedbackValidator;

        public FeedbackService(IUnitOfWork unitOfWork, IMapper mapper, IFeedbackValidator feedbackValidator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _feedbackValidator = feedbackValidator;
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

            _feedbackValidator.ValidateIfFeedbackExist(feedback);

            return _mapper.Map<GetFeedbackDTO>(feedback);
        }

        public async Task<UpdateFeedbackDTO> UpdateFeedbackAsync(UpdateFeedbackDTO updatedFeedback)
        {
            var feedback = await _unitOfWork.Feedbacks.UpdateAsync(_mapper.Map<Feedback>(updatedFeedback));

            return _mapper.Map<UpdateFeedbackDTO>(feedback);
        }
    }
}
