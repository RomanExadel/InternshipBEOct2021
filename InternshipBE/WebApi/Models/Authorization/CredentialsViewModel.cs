using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi.Models.Authorization
{
	public class CredentialsViewModel
	{
		[Required(ErrorMessage = "Login is required")]
		public string Login { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
	}
}
