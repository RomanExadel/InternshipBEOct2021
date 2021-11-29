using System.Collections.Generic;

namespace BL.DTOs
{
    public class TeamDTO
    {
        public int Id { get; set; }

        public int InternshipId { get; set; }

        public string Name { get; set; }

        public List<UserDTO> Users { get; set; }

        public List<CandidateDTO> Candidates { get; set; }
    }
}
