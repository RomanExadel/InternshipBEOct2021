using Shared.Enums;
using System.Collections.Generic;
#nullable enable

namespace DAL.Entities.Filtering
{
    public class CandidateFilterModel 
    {
        public string? Location { get; set; }

        public List<string>? LanguageTypes { get; set; }

        public List<string>? StatusTypes { get; set; }

        public List<string>? EnglishLevels { get; set; }

        public string? UserId { get; set; }

    }
}
