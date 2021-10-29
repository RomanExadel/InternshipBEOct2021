using System;

namespace DAL.Entities
{
    public class InterviewInvite
    {
        public int Id { get; set; }

        public User User { get; set; }

        public int CandidateId { get; set; }

        public Candidate Candidate { get; set; }

        public DateTime ContactDate { get; set; }
    }
}
