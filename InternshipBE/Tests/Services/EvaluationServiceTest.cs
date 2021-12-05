using AutoMapper;
using BL.DTOs;
using BL.EqualityComparers;
using BL.Interfaces;
using BL.Mapping;
using BL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Tests.Fixtures;
using Xunit;

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

        [Fact]
        public async void GetEvaluationsByFeedbackIdAsync_WhenFeedbackIsExist_GettingEvaluations()
        {
            var feedbackId = It.IsAny<int>();
            var outputEvaluations = _mapper.Map<List<Evaluation>>(_evaluationDtos.Where(x => x.FeedbackId == feedbackId).ToList());
            var expectedEvaluationDtos = _evaluationDtos.Where(x => x.FeedbackId == feedbackId).ToList();

            _uowMock.Setup(x => x.Evaluations.GetEvaluationsByFeedbackIdAsync(feedbackId))
                .ReturnsAsync(outputEvaluations);

            var actualEvaluationDtos = await _evaluationService.GetEvaluationsByFeedbackIdAsync(feedbackId);

            Assert.Equal(expectedEvaluationDtos, actualEvaluationDtos, new EvaluationDTOEqualityComparer());
        }
    }
}
