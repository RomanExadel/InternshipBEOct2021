using BL.DTOs.CountryDTOs;
using BL.DTOs.InternshipStackDTOs;
using System.Collections.Generic;

namespace BL.DTOs.InternshipDTOs
{
    public class CreateInternshipDTO : InternshipDTO
    {
        public new List<InternshipStackDTO> InternshipStacks { get; set; }

        public new List<CountryDTO> Locations { get; set; }
    }
}