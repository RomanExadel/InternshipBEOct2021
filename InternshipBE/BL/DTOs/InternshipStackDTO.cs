using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs
{
    public class InternshipStackDTO
    {
        public int Id { get; set; }

        public int InternshipId { get; set; }

        public StackType TechnologyStackType { get; set; }

        public InternshipDTO Internship { get; set; }
    }
}
