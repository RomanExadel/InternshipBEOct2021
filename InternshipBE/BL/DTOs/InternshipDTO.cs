using Shared.Enums;
using System;
using System.Collections.Generic;

namespace BL.DTOs
{
    public class InternshipDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Requirements { get; set; }

        public int MaxCandidateCount { get; set; }

        public DateTime RegistrationStartDate { get; set; }

        public DateTime RegistrationFinishDate { get; set; }

        public LanguageType LanguageType { get; set; }

        public InternshipStatusType InternshipStatusType { get; set; }

        public string ImageLink { get; set; }

        public List<StackType> InternshipStackTypes { get; set; }

        public List<int> LocationIds { get; set; }

        public int CandidatesCount { get; set; }

        public int DeclinedCandidatesCount { get; set; }

        public int AcceptedCandidatesCount { get; set; }

        public int AbandonedCandidatesCount { get; set; }

        public int SuccessfullyFinishedCandidatesCount { get; set; }

        public int TeamsCount { get; set; }
    }
}
