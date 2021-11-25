using Shared.Enums;

namespace DAL.Entities
{
    public class InternshipLanguage
    {
        public int Id { get; set; }

        public LanguageType LanguageType { get; set; }

        public int? InternshipId { get; set; }

        public Internship Internship { get; set; }
    }
}
