using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
	public class User : IdentityUser
	{
        public string Position { get; set; }
        
        public ICollection<Candidate> Candidates { get; set; }

        public ICollection<Internship> Internships { get; set; }
        
        public ICollection<Team> Teams { get; set; }

        public ICollection<BestContactTime> BestContactTimes { get; set; }
    }	
}
