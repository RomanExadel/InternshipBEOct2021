using Shared.Enums;

namespace DAL.Entities
{
    public class InternshipLanguage
    {
        public int Id { get; set; }

        public InternshipLanguageType LanguageType { get; set; }

        public int? InternshipId { get; set; }

        public Internship Internship { get; set; }
    }
}
