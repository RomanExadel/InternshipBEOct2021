using System.Collections.Generic;

namespace DAL.Entities.Filtering
{
    public class CandidateFilterModel 
    {
        public List<string> Locations { get; set; }

        public List<string> LanguageTypes { get; set; }

        public List<string> StatusTypes { get; set; }

        public List<string> EnglishLevels { get; set; }

        public string UserId { get; set; }

    }
}
