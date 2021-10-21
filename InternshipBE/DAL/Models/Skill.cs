using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Skill
    {
        public int Id { get; set; }

        public Stack Stack { get; set; }

        public string Name { get; set; }

        public string IsHardSkill { get; set; }

    }
}
