using Shared.Enums;

namespace DAL.Entities
{
    public class InternshipStack
    {
        public int Id { get; set; }

        public int InternshipId { get; set; }

        public StackType TechnologyStack { get; set; }

        public Internship Internship { get; set; }
    }
}
