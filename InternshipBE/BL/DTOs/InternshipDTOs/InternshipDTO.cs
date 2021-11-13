using BL.DTOs.CountryDTOs;
using BL.DTOs.InternshipStackDTOs;
using System;
using System.Collections.Generic;

namespace BL.DTOs.InternshipDTOs
{
    public class InternshipDTO
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Requirements { get; set; }

        public int MaxCandidateCount { get; set; }

        public DateTime RegistrationStartDate { get; set; }

        public DateTime RegistrationFinishDate { get; set; }

        public string LanguageType { get; set; }

        public string InternshipStatusType { get; set; }

        public string ImageLink { get; set; }

        public virtual List<InternshipStackDTO> InternshipStacks { get; set; }

        public virtual List<GetCountryDTO> Locations { get; set; }
    }
}
