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

        public ICollection<Candidate> Candidate { get; set; }

        public ICollection<InternshipStack> InternshipStack { get; set; }

        public ICollection<UserInternship> UserInternship { get; set; }
    }
}
