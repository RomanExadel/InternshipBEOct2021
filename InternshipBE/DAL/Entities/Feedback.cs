using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Feedback
    {
        public int Id { get; set; }

        public int UserCandidateId { get; set; }

        public EnglishLevel EnglishLevel { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }


    }
}

