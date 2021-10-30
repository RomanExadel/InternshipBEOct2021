using Shared.Enums;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Internship
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

        public ICollection<Candidate> Candidates { get; set; }

        public ICollection<InternshipStack> InternshipStacks { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
