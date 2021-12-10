using DAL.Entities;
using Shared.Enums;
using System.Collections.Generic;

namespace Tests.UnitTests.Fixtures
{
    public class SkillFixture
    {
        private readonly List<Skill> _skills;

        public SkillFixture()
        {
            _skills = new List<Skill>
            {
                new Skill { Id = 1, Name = "Name", StackType = StackType.BackEnd, IsHardSkill = true, Evaluations = null },
                new Skill { Id = 2, Name = "Name", StackType = StackType.FrontEnd, IsHardSkill = false, Evaluations = null },
                new Skill { Id = 3, Name = "Name", StackType = StackType.FullStack, IsHardSkill = true, Evaluations = null },
                new Skill { Id = 4, Name = "Name", StackType = StackType.BackEnd, IsHardSkill = false, Evaluations = null },
                new Skill { Id = 5, Name = "Name", StackType = StackType.Testing, IsHardSkill = true, Evaluations = null },
                new Skill { Id = 6, Name = "Name", StackType = StackType.DevOps, IsHardSkill = false, Evaluations = null },
                new Skill { Id = 7, Name = "Name", StackType = StackType.BackEnd, IsHardSkill = true, Evaluations = null },
                new Skill { Id = 8, Name = "Name", StackType = StackType.FrontEnd, IsHardSkill = false, Evaluations = null },
                new Skill { Id = 9, Name = "Name", StackType = StackType.FrontEnd, IsHardSkill = true, Evaluations = null },
                new Skill { Id = 10, Name = "Name", StackType = StackType.FrontEnd, IsHardSkill = false, Evaluations = null }
            };
        }

        public List<Skill> GetSkills()
        {
            return _skills;
        }
    }
}
