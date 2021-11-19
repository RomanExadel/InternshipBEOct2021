using Shared.Enums;

namespace DAL.Entities
{
    public class InternshipStack
    {
        public int Id { get; set; }

        public StackType TechnologyStackType { get; set; }

        public int? InternshipId { get; set; }

        public Internship Internship { get; set; }
    }
}