using System.Collections.Generic;

namespace BL.DTOs
{
    public class TeamDTO
    {
        public int Id { get; set; }

        public int InternshipId { get; set; }

        public string Name { get; set; }

        public InternshipDTO Internship { get; set; }

        public List<UserDTO> User { get; set; }

        public List<CandidateDTO> Candidate { get; set; }
    }
}
