using System;

namespace DAL.Entities
{
    public class Evaluation
    {   
        public int Id { get; set; }
        public int FeedbackId { get; set; }
        public int SkillId { get; set; }
        public int Value { get; set; }

        public Feedback Feedback { get; set; }
        public Skill Skill { get; set; }
    }
}
