using BL.DTOs.EvaluationDTOs;
using System.Collections.Generic;

namespace BL.DTOs.FeedbackDTOs
{
    public class CreateFeedbackDTO : FeedbackDTO
    {
        public new List<EvaluationDTO> Evaluations { get; set; }
    }
}
