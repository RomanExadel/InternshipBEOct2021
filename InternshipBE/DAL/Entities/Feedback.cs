using Shared.Enums;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Feedback
    {
        public int Id { get; set; }

        public int CandidateId { get; set; }

        public EnglishLevelType EnglishLevelType { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public User User { get; set; }

        public Candidate Candidate { get; set; }

        public ICollection<Evaluation> Evaluations { get; set; }

        public string UserId { get; set; }
    }
}