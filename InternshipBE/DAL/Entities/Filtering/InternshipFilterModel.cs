using System.Collections.Generic;

namespace DAL.Entities.Filtering
{
    public class InternshipFilterModel<T>
    {
        public List<T> Locations { get; set; }

        public List<T> LanguageTypes { get; set; }

        public string InternshipStatusType { get; set; }

        public List<T> InternshipStacks { get; set; }

        public List<T> AttachedUsers { get; set; }

        public int IntershipYear { get; set; }
    }
}
