using AutoMapper;
using BL.DTOs;
using BL.EqualityComparers;
using BL.Mapping;
using BL.Services;
using DAL.Interfaces;
using Moq;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tests.Fixtures;
using Xunit;

namespace Tests.Services
{
    public class SkillServiceTest
    {
        SkillFixture _fixture;
        List<SkillDTO> _skillDtos;

        IMapper _mapper;
        Mock<IUnitOfWork> _uowMock;

        public SkillServiceTest()
        {
            _fixture = new SkillFixture();
            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();
            _skillDtos = _mapper.Map<List<SkillDTO>>(_fixture.GetSkills());
            _uowMock = new Mock<IUnitOfWork>();
        }

        [Fact]
        public async void GetSkillsByStackTypeAsync_WhenStackIsBackEnd_GettingBackEndSkills()
        {
            //Arrange
            var stack = StackType.BackEnd;
            var expectedSkillDtos = _skillDtos.Where(x => x.StackType == stack.ToString()).ToList();
            var skillService = new SkillService(_uowMock.Object, _mapper);
            
            _uowMock.Setup(x => x.Skills.GetSkillsByStackTypeAsync(stack))
                .Returns(Task.Run(() => _fixture.GetSkills().Where(x => x.StackType == stack).ToList()));

            //Act
            var actualSkillDtos = await skillService.GetSkillsByStackTypeAsync(stack);

            //Assert
            Assert.Equal(expectedSkillDtos, actualSkillDtos, new SkillDTOEqualityComparer());
        }
    }
}
