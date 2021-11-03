using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs
{
    public class FeedbackDTO
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int CandidateId { get; set; }

        public EnglishLevelType EnglishLevelType { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
