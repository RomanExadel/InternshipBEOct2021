using System.Collections.Generic;

namespace DAL.Entities.Filtering
{
    public class CandidateFilterModel<T>
    {
        public List<string> Locations { get; set; }

        public List<T> LanguageTypes { get; set; }

        public List<T> StatusTypes { get; set; }

        public List<T> EnglishLevels { get; set; }

        public string UserId { get; set; }

    }
}