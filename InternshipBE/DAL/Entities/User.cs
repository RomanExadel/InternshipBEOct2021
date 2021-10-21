using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class User : IdentityUser
	{
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Position { get; set; }

        public DateTime BestContactTime { get; set; }
    }	
}
