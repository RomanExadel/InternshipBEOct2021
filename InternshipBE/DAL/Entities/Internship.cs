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

        public Language Language { get; set; }

        public ICollection<Candidate> Candidate { get; set; }

        public ICollection<InternshipStack> InternshipStack { get; set; }
    }
}
