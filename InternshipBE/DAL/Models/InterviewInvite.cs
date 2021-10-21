using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class InterviewInvite
    {
        public int Id { get; set; }

        public int UserCandidateId { get; set; }

        public DateTime ContactDate { get; set; }

    }
}
