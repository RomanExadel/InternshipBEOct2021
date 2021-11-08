using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class EvaluationService : IEvaluationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EvaluationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<EvaluationDTO> CreateEvaluationAsync(EvaluationDTO evaluationDto)
        {
            //var feedback = await _unitOfWork.Feedbacks.GetByIdAsync(evaluationDto.FeedbackId);
            //var skill = await _unitOfWork.Skills.GetByIdAsync(evaluationDto.SkillId);

            //var evaluation = new Evaluation()
            //{
            //    FeedbackId = feedback.Id,
            //    Feedback = feedback,
            //    SkillId = skill.Id,
            //    Skill = skill,
            //    Value = evaluationDto.Value
            //};

            var evaluation = await _unitOfWork.Evaluations.CreateAsync(_mapper.Map<Evaluation>(evaluationDto));
            await _unitOfWork.SaveAsync();

            return _mapper.Map<EvaluationDTO>(evaluation);
        }

        public async Task<List<EvaluationDTO>> GetEvaluationsByFeedbackId(int feedbackId)
        {
            var evaluations = await _unitOfWork.Evaluations.GetEvaluationsByFeedbackId(feedbackId);
            return _mapper.Map<List<EvaluationDTO>>(evaluations);
        }
    }
}
