using Shared.Enums;
#nullable enable

namespace DAL.Entities.Filtering
{
    public class CandidateFilterModel
    {
        public string? Location { get; set; }

        public LanguageType? LanguageType { get; set; }

        public CandidateStatusType? StatusType { get; set; }

        public string? HardSkills { get; set; }

        ///public int? IntershipYear { get; set; }

        public EnglishLevelType? EnglishLevel { get; set; }

        public string? UserId { get; set; }

    }
}
