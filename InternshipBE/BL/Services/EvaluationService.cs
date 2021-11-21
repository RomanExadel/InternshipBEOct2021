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

        public async Task<EvaluationDTO> CreateEvaluationAsync(EvaluationDTO createEvaluationDto)
        {
            var isExistedSkill = createEvaluationDto.SkillId == 0 && createEvaluationDto.Skill.Id == 0 ? false : true;
            var evaluation = _mapper.Map<Evaluation>(createEvaluationDto);

            if (!isExistedSkill)
            {
                evaluation.Skill = await _unitOfWork.Skills.CreateAsync(_mapper.Map<Skill>(createEvaluationDto.Skill));
            }

            evaluation = await _unitOfWork.Evaluations.CreateAsync(evaluation);

            createEvaluationDto = _mapper.Map<EvaluationDTO>(evaluation);

            if (isExistedSkill)
            {
                var skill = await _unitOfWork.Skills.GetByIdAsync(evaluation.SkillId);

                createEvaluationDto.Skill = _mapper.Map<SkillDTO>(skill);
            }

            return createEvaluationDto;
        }

        public async Task<List<EvaluationDTO>> GetEvaluationsByFeedbackIdAsync(int feedbackId)
        {
            var evaluations = await _unitOfWork.Evaluations.GetEvaluationsByFeedbackId(feedbackId);

            return _mapper.Map<List<EvaluationDTO>>(evaluations);
        }

        public async Task<EvaluationDTO> UpdateEvaluationAsync(EvaluationDTO fullEvaluationDto)
        {
            var evaluation = _mapper.Map<Evaluation>(fullEvaluationDto);

            evaluation.Skill = _mapper.Map<Skill>(fullEvaluationDto.Skill);
            evaluation = await _unitOfWork.Evaluations.UpdateAsync(evaluation);

            return _mapper.Map<EvaluationDTO>(evaluation);
        }
    }
}