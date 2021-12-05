using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
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

            return _mapper.Map<FeedbackDTO>(feedback);
        }

        public async Task<FeedbackDTO> UpdateFeedbackAsync(FeedbackDTO updatedFeedback)
        {
            var feedback = _mapper.Map<Feedback>(updatedFeedback);
            var evaluations = feedback.Evaluations.ToList();

            feedback.Evaluations.Clear();
            await _unitOfWork.Feedbacks.UpdateAsync(feedback);
            await _unitOfWork.Evaluations.DeleteMissingEvaluationsByFeedbackId(feedback.Id, evaluations);
            await _unitOfWork.Evaluations.BulkSaveAsync(evaluations.Where(x => x.Id == 0).ToList());
            feedback.Evaluations = await _unitOfWork.Evaluations.GetEvaluationsByFeedbackIdAsync(feedback.Id);

            return _mapper.Map<FeedbackDTO>(feedback);
        }
    }
}