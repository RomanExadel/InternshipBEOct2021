using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class UserCandidate
    {
        public int Id {  get; set; }
        public int UserId {  get; set; }
        public int CandidateId { get; set; }

        public Candidate Candidate { get; set; }
        public User User { get; set; }
        public ICollection<InterviewInvite> InterviewInvite { get; set; }
        public ICollection<Feedback> Feedback { get; set; }
    }
}
