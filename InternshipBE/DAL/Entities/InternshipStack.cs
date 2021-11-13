using Shared.Enums;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class InternshipStack
    {
        public int Id { get; set; }

        public StackType TechnologyStackType { get; set; }

        public ICollection<Internship> Internships { get; set; }
    }
}