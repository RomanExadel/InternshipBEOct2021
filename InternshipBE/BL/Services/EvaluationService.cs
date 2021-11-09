using AutoMapper;
using BL.DTOs;
using BL.DTOs.EvaluationDTOs;
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

        public async Task<CreateEvaluationDTO> CreateEvaluationAsync(CreateEvaluationDTO createEvaluationDto)
        {
            var evaluation = await _unitOfWork.Evaluations.CreateAsync(_mapper.Map<Evaluation>(createEvaluationDto));
            await _unitOfWork.SaveAsync();

            return _mapper.Map<CreateEvaluationDTO>(evaluation);
        }

        public async Task<List<GetEvaluationDTO>> GetEvaluationsByFeedbackId(int feedbackId)
        {
            var evaluations = await _unitOfWork.Evaluations.GetEvaluationsByFeedbackId(feedbackId);
            return _mapper.Map<List<GetEvaluationDTO>>(evaluations);
        }

        public async Task<FullEvaluationDTO> UpdateEvaluationAsync(FullEvaluationDTO fullEvaluationDto)
        {
            var evaluation = _mapper.Map<Evaluation>(fullEvaluationDto);

            evaluation = await _unitOfWork.Evaluations.UpdateAsync(evaluation);
            await _unitOfWork.SaveAsync();

            return _mapper.Map<FullEvaluationDTO>(evaluation);
        }
    }
}
