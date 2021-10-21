using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Evaluation
    {
        public int Id { get; set; }

        public int FeedbackId { get; set; }

        public int SkillId { get; set; }

        public int Value { get; set; }

    }
}
