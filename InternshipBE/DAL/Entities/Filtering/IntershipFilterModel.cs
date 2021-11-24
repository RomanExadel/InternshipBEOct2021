using Shared.Enums;
using System.Collections.Generic;
#nullable enable

namespace DAL.Entities.Filtering
{
    public class IntershipFilterModel
    {
        public string? Location { get; set; }

        public List<LanguageType>? LanguageTypes { get; set; }

        public InternshipStatusType? InternshipStatusType { get; set; }

        public List<StackType>? InternshipStacks { get; set; }

        public List<string>? AttachedUsers { get; set; }

        public int? IntershipYear { get; set; }
    }
}
