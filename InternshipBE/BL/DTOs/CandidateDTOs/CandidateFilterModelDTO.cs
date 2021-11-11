using Shared.Enums;
using System;
#nullable enable

namespace BL.DTOs.CandidateDTOs
{
    public class CandidateFilterModelDTO
    {
		public string? Location { get; set; }

        public StackType? StackType { get; set; }

        public CandidateStatusType? StatusType { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public EnglishLevelType? EnglishLevelType { get; set; }

    }
}
