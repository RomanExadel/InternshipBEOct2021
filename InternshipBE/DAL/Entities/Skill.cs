using Shared.Enums;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Skill
    {
        public int Id { get; set; }

        public StackType StackType { get; set; }

        public string Name { get; set; }

        public bool IsHardSkill { get; set; }

        public ICollection<Evaluation> Evaluation { get; set; }
    }
}
