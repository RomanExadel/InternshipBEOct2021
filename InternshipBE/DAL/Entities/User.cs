using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
	public class User : IdentityUser
	{
        public int RoleId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Position { get; set; }

        public DateTime BestContactTime { get; set; }

        public Role Role { get; set; }

        public ICollection<UserCandidate> UserCandidate { get; set; }
    }	
}
