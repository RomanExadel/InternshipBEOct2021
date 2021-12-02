using System;
using System.Collections.Generic;

namespace BL.DTOs
{
    public class FeedbackDTO
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserRoleType { get; set; }

        public int CandidateId { get; set; }

        public string EnglishLevelType { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public List<EvaluationDTO> Evaluations { get; set; }

        public int FinalEvaluation { get; set; }
    }
}
