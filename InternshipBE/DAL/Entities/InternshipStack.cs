using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class InternshipStack
    {
        public int Id { get; set; }

        public int InternshipId { get; set; }

        public Stack TechnologyStack { get; set; }
    }
}
