using BL.DTOs.EvaluationDTOs;
using System.Collections.Generic;

namespace BL.DTOs.FeedbackDTOs
{
    public class GetFeedbackDTO : FeedbackDTO
    {
        public new List<StackGetEvaluationDTO> Evaluations { get; set; }
    }
}
