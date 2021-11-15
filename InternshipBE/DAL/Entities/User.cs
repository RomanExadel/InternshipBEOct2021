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

		public ICollection<Candidate> Candidates { get; set; }

		public ICollection<Internship> Internships { get; set; }

		public ICollection<Team> Teams { get; set; }

		public ICollection<BestContactTime> BestContactTimes { get; set; }
	}
}
