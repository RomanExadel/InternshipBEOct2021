using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class EvaluationService : IEvaluationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly AbstractValidator<EvaluationDTO> _validations;

        public EvaluationService(IUnitOfWork unitOfWork, IMapper mapper, AbstractValidator<EvaluationDTO> validations)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validations = validations;
        }

        public async Task<EvaluationDTO> CreateEvaluationAsync(EvaluationDTO createEvaluationDto)
        {
            var evaluation = _mapper.Map<Evaluation>(createEvaluationDto);

            evaluation = await _unitOfWork.Evaluations.CreateAsync(evaluation);
            createEvaluationDto = _mapper.Map<EvaluationDTO>(evaluation);

            var skill = await _unitOfWork.Skills.GetByIdAsync(evaluation.SkillId);

            createEvaluationDto.Skill = _mapper.Map<SkillDTO>(skill);

            return createEvaluationDto;
        }

        public async Task<List<EvaluationDTO>> GetEvaluationsByFeedbackIdAsync(int feedbackId)
        {
            var evaluations = await _unitOfWork.Evaluations.GetEvaluationsByFeedbackId(feedbackId);
            return _mapper.Map<List<EvaluationDTO>>(evaluations);
        }

        public async Task<EvaluationDTO> UpdateEvaluationAsync(EvaluationDTO fullEvaluationDto)
        {
            await _validations.ValidateAndThrowAsync(fullEvaluationDto);

            var evaluation = _mapper.Map<Evaluation>(fullEvaluationDto);

            evaluation = await _unitOfWork.Evaluations.UpdateAsync(evaluation);

            return _mapper.Map<EvaluationDTO>(evaluation);
        }
    }
}