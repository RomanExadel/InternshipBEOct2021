using AutoMapper;
using BL.DTOs;
using BL.EqualityComparers;
using BL.Interfaces;
using BL.Mapping.Profiles;
using BL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Tests.UnitTests.Fixtures;
using Xunit;

namespace Tests.UnitTests.Services
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
            _mapper = new MapperConfiguration(cfg => cfg.AddProfile(new EvaluationProfile())).CreateMapper();
            _evaluationDtos = _mapper.Map<List<EvaluationDTO>>(_evaluationFixture.GetEvaluations());
            _uowMock = new Mock<IUnitOfWork>();
            _evaluationService = new EvaluationService(_uowMock.Object, _mapper);
        }

        [Fact]
        public async void GetEvaluationsByFeedbackIdAsync_WhenFeedbackIsExist_GettingEvaluations()
        {
            //Arrange
            var feedbackId = 1;
            var outputEvaluations = _mapper.Map<List<Evaluation>>(_evaluationDtos.Where(x => x.FeedbackId == feedbackId).ToList());
            var expectedEvaluationDtos = _evaluationDtos.Where(x => x.FeedbackId == feedbackId).ToList();

            //Act
            _uowMock.Setup(x => x.Evaluations.GetEvaluationsByFeedbackIdAsync(It.IsAny<int>()))
                .ReturnsAsync(outputEvaluations);

            var actualEvaluationDtos = await _evaluationService.GetEvaluationsByFeedbackIdAsync(feedbackId);

            //Assert
            Assert.Equal(expectedEvaluationDtos, actualEvaluationDtos, new EvaluationDTOEqualityComparer());
        }

        [Fact]
        public async void GetEvaluationsByFeedbackIdAsync_WhenFeedbackIsNotExist_GettingEmptyList()
        {
            //Arrange
            var feedbackId = -1;
            var outputEvaluations = _mapper.Map<List<Evaluation>>(_evaluationDtos.Where(x => x.FeedbackId == feedbackId).ToList());
            var expectedEvaluationDtos = new List<EvaluationDTO>();

            //Act
            _uowMock.Setup(x => x.Evaluations.GetEvaluationsByFeedbackIdAsync(feedbackId))
                .ReturnsAsync(outputEvaluations);

            var actualEvaluationDto = await _evaluationService.GetEvaluationsByFeedbackIdAsync(feedbackId);

            //Assert
            Assert.Equal(expectedEvaluationDtos, actualEvaluationDto, new EvaluationDTOEqualityComparer());
        }
        
        [Fact]
        public async void CreateEvaluationAsync_WhenFeedbackIsCorrect_GettingNewEvaluation()
        {
            //Arrange
            var inputEvaluationDTO = new EvaluationDTO { Id = 0, FeedbackId = 1, SkillId = 1, Value = 1 };
            var inputEvaluation = _mapper.Map<Evaluation>(inputEvaluationDTO);
            var outputEvaluation = new Evaluation { Id = It.IsAny<int>(), FeedbackId = 1, SkillId = 1, Value = 1 };
            var expectedEvaluationDto = _mapper.Map<EvaluationDTO>(outputEvaluation);

            //Act
            _uowMock.Setup(x => x.Evaluations.CreateAsync(It.IsAny<Evaluation>()))
                .ReturnsAsync(outputEvaluation);
            _uowMock.Setup(x => x.Skills.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(null as Skill);

            var actualEvaluationDto = await _evaluationService.CreateEvaluationAsync(inputEvaluationDTO);

            //Assert
            Assert.Equal(expectedEvaluationDto, actualEvaluationDto, new EvaluationDTOEqualityComparer());
        }

        [Fact]
        public async void UpdateEvaluationAsync_WhenFieldsChanged_GettingUpdatedEvaluation()
        {
            //Arrange
            var expectedEvaluationDto = _evaluationDtos[0];
            var expectedEvaluation = _mapper.Map<Evaluation>(expectedEvaluationDto);

            //Act
            _uowMock.Setup(x => x.Evaluations.UpdateAsync(It.IsAny<Evaluation>()))
                .ReturnsAsync(expectedEvaluation);

            var actualEvaluationDto = await _evaluationService.UpdateEvaluationAsync(expectedEvaluationDto);

            //Assert
            Assert.Equal(expectedEvaluationDto, actualEvaluationDto, new EvaluationDTOEqualityComparer());
        }
    }
}