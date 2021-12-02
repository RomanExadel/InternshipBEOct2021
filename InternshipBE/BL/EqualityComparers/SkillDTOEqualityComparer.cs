using BL.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BL.EqualityComparers
{
    public class SkillDTOEqualityComparer : IEqualityComparer<SkillDTO>
    {
        public bool Equals(SkillDTO x, SkillDTO y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;

            return x.Id == y.Id && x.Name == y.Name && x.StackType == y.StackType && x.IsHardSkill == y.IsHardSkill;
        }

        public int GetHashCode([DisallowNull] SkillDTO obj)
        {
            return HashCode.Combine(obj.Id, obj.Name, obj.StackType, obj.IsHardSkill);
        }
    }
}