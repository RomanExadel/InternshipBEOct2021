using System;
using System.Collections.Generic;

namespace BL.DTOs
{
    public class InternshipDTO
    {
        public int Id { get; set; }

        public string SpreadSheetId { get; set; }

        public int CandidatesCount { get; set; }

        public int DeclinedCandidatesCount { get; set; }

        public int AcceptedCandidatesCount { get; set; }

        public int AbandonedCandidatesCount { get; set; }

        public int SuccessfullyFinishedCandidatesCount { get; set; }

        public int TeamsCount { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Requirements { get; set; }

        public int MaxCandidateCount { get; set; }

        public DateTime RegistrationStartDate { get; set; }

        public DateTime RegistrationFinishDate { get; set; }

        public List<LanguageDTO> LanguageTypes { get; set; }

        public string InternshipStatusType { get; set; }

        public string ImageLink { get; set; }

        public List<InternshipStackDTO> InternshipStacks { get; set; }

        public List<CountryDTO> Locations { get; set; }

        public List<TeamDTO> Teams { get; set; }

        public List<UserDTO> Users { get; set; }
    }
}