using BL.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BL.EqualityComparers
{
    public class EvaluationDTOEqualityComparer : IEqualityComparer<EvaluationDTO>
    {
        public bool Equals(EvaluationDTO x, EvaluationDTO y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;

            return x.Id == y.Id && x.FeedbackId == y.FeedbackId && x.SkillId == y.SkillId && x.Value == y.Value;
        }

        public int GetHashCode([DisallowNull] EvaluationDTO obj)
        {
            return HashCode.Combine(obj.Id, obj.FeedbackId, obj.SkillId, obj.Value);
        }
    }
}
