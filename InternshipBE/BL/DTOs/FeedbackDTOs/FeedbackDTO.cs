using BL.DTOs.EvaluationDTOs;
using System;
using System.Collections.Generic;

namespace BL.DTOs.FeedbackDTOs
{
    public class FeedbackDTO
    {
        public string UserId { get; set; }

        public int CandidateId { get; set; }

        public string EnglishLevelName { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public virtual List<GetEvaluationDTO> Evaluations { get; set; }
    }
}
