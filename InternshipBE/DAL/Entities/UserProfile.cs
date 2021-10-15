using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	public class UserProfile
	{
		[Key]
		[ForeignKey("ApplicationUser")]
		public int Id { get; set; }

		public string Name { get; set; }
		public string Email { get; set; }

		public int UserId { get; set; }
		public virtual User User { get; set; }
	}
}
