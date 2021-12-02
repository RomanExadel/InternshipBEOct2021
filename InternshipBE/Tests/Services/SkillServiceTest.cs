using AutoMapper;
using BL.DTOs;
using BL.EqualityComparers;
using BL.Interfaces;
using BL.Mapping;
using BL.Services;
using DAL.Entities;
using DAL.Interfaces;
using Moq;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tests.Fixtures;
using Xunit;

namespace Tests.Services
{
    public class SkillServiceTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _uowMock;
        private readonly ISkillService _skillService;
        private readonly SkillFixture _skillFixture;
        private readonly List<SkillDTO> _skillDtos;

        public SkillServiceTest()
        {
            _skillFixture = new SkillFixture();
            _mapper = MapperConfigurationProvider.GetConfig().CreateMapper();
            _skillDtos = _mapper.Map<List<SkillDTO>>(_skillFixture.GetSkills());
            _uowMock = new Mock<IUnitOfWork>();
            _skillService = new SkillService(_uowMock.Object, _mapper);
        }

        [Fact]
        public async void GetSkillsByStackTypeAsync_WhenStackIsBackEnd_GettingBackEndSkills()
        {
            //Arrange
            var stack = StackType.BackEnd;
            var expectedSkillDtos = _skillDtos.Where(x => x.StackType == stack.ToString()).ToList();
            
            _uowMock.Setup(x => x.Skills.GetSkillsByStackTypeAsync(It.IsAny<StackType>()))
                .Returns(Task.Run(() => _skillFixture.GetSkills().Where(x => x.StackType == stack).ToList()));

            //Act
            var actualSkillDtos = await _skillService.GetSkillsByStackTypeAsync(stack);

            //Assert
            Assert.Equal(expectedSkillDtos, actualSkillDtos, new SkillDTOEqualityComparer());
        }

        [Fact]
        public async void CreateSkillAsync_WhenSendingCorrectSkill_GettingSkillWithNewId11()
        {
            //Arrange
            var inputSkill = new Skill { Id = 0, Name = "Name", StackType = StackType.Testing, IsHardSkill = true };
            var outputSkill = new Skill { Id = 11, Name = "Name", StackType = StackType.Testing, IsHardSkill = true };
            var inputSkillDto = _mapper.Map<SkillDTO>(inputSkill);
            var expectedSkillDto = _mapper.Map<SkillDTO>(outputSkill);

            _uowMock.Setup(x => x.Skills.CreateAsync(It.IsAny<Skill>()))
                .ReturnsAsync(outputSkill);

            //Act
            var actualSkillDto = await _skillService.CreateSkillAsync(inputSkillDto);

            //Assert
            Assert.Equal(expectedSkillDto, actualSkillDto, new SkillDTOEqualityComparer());
        }

        [Fact]
        public async void UpdateSkillAsync_WhenChangingAllFields_GettingChangedSkill()
        {
            //Arrange
            var inputSkill = _mapper.Map<Skill>(_skillDtos[0]);
            var outputSkill = new Skill { Id = inputSkill.Id, Name = "Updated", StackType = StackType.FrontEnd, IsHardSkill = false };
            var expectedSkillDto = _mapper.Map<SkillDTO>(outputSkill);

            _uowMock.Setup(x => x.Skills.UpdateAsync(It.IsAny<Skill>()))
                .ReturnsAsync(outputSkill);

            //Act
            var actualSkillDto = await _skillService.UpdateSkillAsync(_skillDtos[0]);

            //Assert
            Assert.Equal(expectedSkillDto, actualSkillDto, new SkillDTOEqualityComparer());
        }
    }
}