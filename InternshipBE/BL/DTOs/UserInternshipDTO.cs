using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs
{
    public class UserInternshipDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int InternshipId { get; set; }

        public UserDTO User { get; set; }

        public InternshipDTO Internship { get; set; }
    }
}
