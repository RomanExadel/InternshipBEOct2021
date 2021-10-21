using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Position { get; set; }

        public DateTime BestContactTime { get; set; }
        
        

    }
}
