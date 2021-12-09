using BL.Interfaces;
using Xunit;

namespace Tests.IntegrationTests.Services
{
    public class SkillServiceTest
    {
        ISkillService _skillService;

        public SkillServiceTest(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [Fact]
        public void K()
        {
            

            Assert.NotNull(_skillService);
        }
    }
}