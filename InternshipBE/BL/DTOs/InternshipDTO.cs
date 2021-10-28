using DAL.Entities;
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

        public List<CandidateDTO> Candidate { get; set; }

        public List<InternshipStackDTO> InternshipStack { get; set; }

        public List<UserInternshipDTO> UserInternship { get; set; }
    }
}
