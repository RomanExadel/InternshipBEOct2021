using Microsoft.AspNetCore.Identity;
using Shared.Enums;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
	public class User : IdentityUser
	{
        public RoleType RoleType { get; set; }

        public string Position { get; set; }

        public DateTime BestContactTime { get; set; }
        
        public ICollection<Candidate> Candidate { get; set; }

        public ICollection<Internship> Internship { get; set; }
        
        public ICollection<Team> Team { get; set; }
    }	
}
