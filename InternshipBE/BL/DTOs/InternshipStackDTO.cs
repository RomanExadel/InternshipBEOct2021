using Shared.Enums;

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
