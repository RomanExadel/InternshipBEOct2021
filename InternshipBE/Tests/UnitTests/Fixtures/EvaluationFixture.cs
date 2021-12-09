using DAL.Entities;
using System.Collections.Generic;

namespace Tests.UnitTests.Fixtures
{
    public class EvaluationFixture
    {
        private readonly List<Evaluation> _evaluations;

        public EvaluationFixture()
        {
            _evaluations = new List<Evaluation>
            {
                new Evaluation { Id = 1, FeedbackId = 1, Feedback = null, SkillId = 1, Skill = null, Value = 1 },
                new Evaluation { Id = 2, FeedbackId = 1, Feedback = null, SkillId = 2, Skill = null, Value = 2 },
                new Evaluation { Id = 3, FeedbackId = 1, Feedback = null, SkillId = 3, Skill = null, Value = 3 },
                new Evaluation { Id = 4, FeedbackId = 2, Feedback = null, SkillId = 1, Skill = null, Value = 4 },
                new Evaluation { Id = 5, FeedbackId = 2, Feedback = null, SkillId = 2, Skill = null, Value = 4 },
                new Evaluation { Id = 6, FeedbackId = 2, Feedback = null, SkillId = 4, Skill = null, Value = 3 },
                new Evaluation { Id = 7, FeedbackId = 4, Feedback = null, SkillId = 5, Skill = null, Value = 2 },
                new Evaluation { Id = 8, FeedbackId = 4, Feedback = null, SkillId = 6, Skill = null, Value = 1 },
                new Evaluation { Id = 9, FeedbackId = 4, Feedback = null, SkillId = 7, Skill = null, Value = 1 },
                new Evaluation { Id = 10, FeedbackId = 4, Feedback = null, SkillId = 8, Skill = null, Value = 2 },
            };
        }

        public List<Evaluation> GetEvaluations()
        {
            return _evaluations;
        }
    }
}
