using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Authorization
{
	public class CredentialsViewModel
	{
		[Required(ErrorMessage = "Email is required")]
		[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Incorrect email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
	}
}
