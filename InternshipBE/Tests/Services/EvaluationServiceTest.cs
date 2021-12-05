using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using BL.Mapping;
using BL.Services;
using DAL.Interfaces;
using Moq;
using System.Collections.Generic;
using Tests.Fixtures;

namespace Tests.Services
{
    public class EvaluationServiceTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _uowMock;
        private readonly IEvaluationService _evaluationService;
        private readonly EvaluationFixture _evaluationFixture;
        private readonly List<EvaluationDTO> _evaluationDtos;

        public EvaluationServiceTest()
        {
            _evaluationFixture = new EvaluationFixture();
            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();
            _evaluationDtos = _mapper.Map<List<EvaluationDTO>>(_evaluationFixture.GetEvaluations());
            _uowMock = new Mock<IUnitOfWork>();
            _evaluationService = new EvaluationService(_uowMock.Object, _mapper);
        }
    }
}
