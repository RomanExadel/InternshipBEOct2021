using System;

namespace BL.DTOs.FeedbackDTOs
{
    public class FeedbackDTO
    {
        public string UserId { get; set; }

        public int CandidateId { get; set; }

        public string EnglishLevelType { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
