using Shared.Enums;
using System;
using System.Collections.Generic;

namespace BL.DTOs
{
	public class UserDTO
	{
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public RoleType RoleType { get; set; }

        public string Position { get; set; }

        public DateTime BestContactTime { get; set; }

        public List<CandidateDTO> Candidate { get; set; }

        public List<InternshipDTO> Internship { get; set; }

        public List<TeamDTO> Team { get; set; }
    }
}
