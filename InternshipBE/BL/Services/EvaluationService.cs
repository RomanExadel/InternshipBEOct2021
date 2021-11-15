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
            var evaluation = await _unitOfWork.Evaluations.CreateAsync(_mapper.Map<Evaluation>(createEvaluationDto));

            return _mapper.Map<EvaluationDTO>(evaluation);
        }

        public async Task<List<EvaluationDTO>> GetEvaluationsByFeedbackIdAsync(int feedbackId)
        {
            var evaluations = await _unitOfWork.Evaluations.GetEvaluationsByFeedbackId(feedbackId);
            return _mapper.Map<List<EvaluationDTO>>(evaluations);
        }

        public async Task<EvaluationDTO> UpdateEvaluationAsync(EvaluationDTO fullEvaluationDto)
        {
            var evaluation = _mapper.Map<Evaluation>(fullEvaluationDto);

            evaluation = await _unitOfWork.Evaluations.UpdateAsync(evaluation);

            return _mapper.Map<EvaluationDTO>(evaluation);
        }
    }
}
