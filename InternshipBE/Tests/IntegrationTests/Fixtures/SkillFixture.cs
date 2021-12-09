using BL.DTOs;
using Shared.Enums;
using System.Collections.Generic;

namespace Tests.IntegrationTests.Fixtures
{
    public class SkillFixture
    {
        private readonly List<SkillDTO> _skills;

        public SkillFixture()
        {
            _skills = new List<SkillDTO>
            {
                new SkillDTO { Id = 0, Name = "Name", StackType = StackType.BackEnd.ToString(), IsHardSkill = true },
                new SkillDTO { Id = 0, Name = "Name", StackType = StackType.FrontEnd.ToString(), IsHardSkill = false },
                new SkillDTO { Id = 0, Name = "Name", StackType = StackType.FullStack.ToString(), IsHardSkill = true },
                new SkillDTO { Id = 0, Name = "Name", StackType = StackType.BackEnd.ToString(), IsHardSkill = false },
                new SkillDTO { Id = 0, Name = "Name", StackType = StackType.Testing.ToString(), IsHardSkill = true },
                new SkillDTO { Id = 0, Name = "Name", StackType = StackType.DevOps.ToString(), IsHardSkill = false },
                new SkillDTO { Id = 0, Name = "Name", StackType = StackType.BackEnd.ToString(), IsHardSkill = true },
                new SkillDTO { Id = 0, Name = "Name", StackType = StackType.FrontEnd.ToString(), IsHardSkill = false },
                new SkillDTO { Id = 0, Name = "Name", StackType = StackType.FrontEnd.ToString(), IsHardSkill = true },
                new SkillDTO { Id = 0, Name = "Name", StackType = StackType.FrontEnd.ToString(), IsHardSkill = false }
            };
        }

        public List<SkillDTO> GetSkills()
        {
            return _skills;
        }
    }
}
