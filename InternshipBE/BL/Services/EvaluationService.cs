using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
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
            var feedback = await _unitOfWork.Feedbacks.GetByIdAsync(evaluationDto.FeedbackId);
            var skill = await _unitOfWork.Skills.GetByIdAsync(evaluationDto.SkillId);

            var evaluation = new Evaluation()
            {
                FeedbackId = feedback.Id,
                Feedback = feedback,
                SkillId = skill.Id,
                Skill = skill,
                Value = evaluationDto.Value
            };

            evaluation = await _unitOfWork.Evaluations.CreateAsync(evaluation);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<EvaluationDTO>(evaluation);
        }
    }
}
