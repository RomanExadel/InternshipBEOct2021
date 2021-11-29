using BL.DTOs;
using System;

namespace BL.DTOs
{
    public class InterviewInviteDTO
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public UserDTO User { get; set; }

        public int CandidateId { get; set; }

        public CandidateDTO Candidate { get; set; }

        public DateTime ContactDate { get; set; }
    }
}
