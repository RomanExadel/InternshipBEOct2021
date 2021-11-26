using Shared.Enums;
using System.Collections.Generic;
#nullable enable

namespace DAL.Entities.Filtering
{
    public class InternshipFilterModel 
    {
        public List<string>? Locations { get; set; }

        public List<string>? LanguageTypes { get; set; }

        public string? InternshipStatusType { get; set; }

        public List<string>? InternshipStacks { get; set; }

        public List<string>? AttachedUsers { get; set; }

        public int? IntershipYear { get; set; }
    }
}
