using Shared.Enums;
using System;
using System.Collections.Generic;
#nullable enable

namespace BL.DTOs.CandidateDTOs
{
    public class CandidateFilterModelDTO
    {
        public string? Location { get; set; }

        public LanguageType? LanguageType { get; set; }

        public StackType? StackType { get; set; }

        public CandidateStatusType? StatusType { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public List<UserDTO>? Users { get; set; }
    }
}
