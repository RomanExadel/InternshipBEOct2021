using AutoMapper;
using BL.DTOs;
using BL.EqualityComparers;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using Tests.IntegrationTests.Fixtures;
using Xunit;

namespace Tests.IntegrationTests.Services
{
    public class SkillServiceTest
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISkillService _skillService;
        private readonly List<SkillDTO> _skillDtos;

        public SkillServiceTest(ISkillService skillService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _skillDtos = new SkillFixture().GetSkills();
            _skillService = skillService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [Fact]
        public async void GetSkillsByStackTypeAsync_WhenStackIsBackEnd_GettingBackEndSkills()
        {
            var stack = StackType.BackEnd;
            var expectedSkillDtos = _skillDtos.Where(x => x.StackType == stack.ToString()).ToList();

            var skills = _mapper.Map<List<Skill>>(_skillDtos);

            using var transaction = await _unitOfWork.Context.Database.BeginTransactionAsync();

            _unitOfWork.Context.Skills.RemoveRange(_unitOfWork.Context.Skills);
            await _unitOfWork.Context.SaveChangesAsync();

            await _unitOfWork.Skills.BulkSaveAsync(skills);

            var actualSkillDtos = await _skillService.GetSkillsByStackTypeAsync(stack);
            actualSkillDtos.ForEach(x => x.Id = 0);

            Assert.Equal(expectedSkillDtos, actualSkillDtos, new SkillDTOEqualityComparer());

            await transaction.RollbackAsync();
        }

        [Fact]
        public async void GetSkillsByStackTypesAsync_WhenStacksAreBackEndAndFrontEnd_GettingBackEndAndFrontEndSkills()
        {
            var stacks = new StackType[] { StackType.FrontEnd, StackType.BackEnd };
            var expectedSkillDtos = _skillDtos.Where(x => stacks.Contains(Enum.Parse<StackType>(x.StackType))).ToList();

            var skills = _mapper.Map<List<Skill>>(_skillDtos);

            using var transaction = await _unitOfWork.Context.Database.BeginTransactionAsync();

            _unitOfWork.Context.Skills.RemoveRange(_unitOfWork.Context.Skills);
            await _unitOfWork.Context.SaveChangesAsync();

            await _unitOfWork.Skills.BulkSaveAsync(skills);

            var actualSkillDtos = await _skillService.GetSkillsByStackTypesAsync(stacks);
            actualSkillDtos.ForEach(x => x.Id = 0);

            Assert.Equal(expectedSkillDtos, actualSkillDtos, new SkillDTOEqualityComparer());

            await transaction.RollbackAsync();
        }

        [Fact]
        public async void CreateSkillAsync_WhenSendingCorrectSkill_GettingSkillWithNewId()
        {
            using var transaction = await _unitOfWork.Context.Database.BeginTransactionAsync();
            var expectedSkillDto = new SkillDTO { IsHardSkill = true, Name = "Name", StackType = StackType.BackEnd.ToString() };

            var actualSkillDto = await _skillService.CreateSkillAsync(expectedSkillDto);
            expectedSkillDto.Id = actualSkillDto.Id;

            Assert.Equal(expectedSkillDto, actualSkillDto, new SkillDTOEqualityComparer());

            await transaction.RollbackAsync();
        }
    }
}