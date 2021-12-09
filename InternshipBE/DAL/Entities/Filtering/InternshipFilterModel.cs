using System.Collections.Generic;

namespace DAL.Entities.Filtering
{
    public class InternshipFilterModel<T>
    {
        public List<string> Locations { get; set; }

        public List<T> LanguageTypes { get; set; }

        public List<T> InternshipStatusType { get; set; }

        public List<T> InternshipStacks { get; set; }

        public List<string> AttachedUsers { get; set; }

        public int InternshipYear { get; set; }
    }
}
