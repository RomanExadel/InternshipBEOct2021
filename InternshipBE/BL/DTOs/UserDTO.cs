using Shared.Enums;

namespace BL.DTOs
{
	public class UserDTO
	{
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public RoleType Role { get; set; }
    }
}
