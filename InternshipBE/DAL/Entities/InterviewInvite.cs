using System;

namespace DAL.Entities
{
    public class InterviewInvite
    {
        public int Id { get; set; }

        public int UserCandidateId { get; set; }

        public DateTime ContactDate { get; set; }

        public UserCandidate UserCandidate { get; set; }
    }
}
