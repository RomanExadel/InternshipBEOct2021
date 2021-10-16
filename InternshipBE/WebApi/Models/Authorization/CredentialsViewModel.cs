using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Authorization
{
	public class CredentialsViewModel
	{
		[Required(ErrorMessage = "Email is required")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
	}
}
