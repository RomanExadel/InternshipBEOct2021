using BL.DTOs;
using BL.EqualityComparers;
using BL.Interfaces;
using DAL.Interfaces;
using Shared.Enums;
using Xunit;

namespace Tests.IntegrationTests.Services
{
    public class SkillServiceTest
    {
        IUnitOfWork _unitOfWork;
        ISkillService _skillService;

        public SkillServiceTest(ISkillService skillService, IUnitOfWork unitOfWork)
        {
            _skillService = skillService;
            _unitOfWork = unitOfWork;
        }

        [Fact]
        public async void CreateSkillAsync_WhenSendingCorrectSkill_GettingSkillWithNewId()
        {
            using var transaction = _unitOfWork.Context.Database.BeginTransaction();
            var expectedSkillDto = new SkillDTO { IsHardSkill = true, Name = "Name", StackType = StackType.BackEnd.ToString() };

            var actualSkillDto = await _skillService.CreateSkillAsync(expectedSkillDto);
            expectedSkillDto.Id = actualSkillDto.Id;
            await transaction.RollbackAsync();

            Assert.Equal(expectedSkillDto, actualSkillDto, new SkillDTOEqualityComparer());
        }
    }
}