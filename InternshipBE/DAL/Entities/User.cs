using Microsoft.AspNetCore.Identity;
using Shared.Enums;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
	public class User : IdentityUser
	{
        public Role Role { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Position { get; set; }

        public DateTime BestContactTime { get; set; }

        public ICollection<UserCandidate> UserCandidate { get; set; }
    }	
}
