using Shared.Enums;
using System;

namespace BL.DTOs
{
    public class UserDTO
	{
        public string Id { get; set; }

        public string Position { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BestContactTime { get; set; }

        public string UserName { get; set; }

        public RoleType RoleType { get; set; }
    }
}
