using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BL.EqualityComparers
{
    public class InternshipLanguagesEqualityComparer : IEqualityComparer<Internship>
    {
        public bool Equals(Internship x, Internship y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;

            return x.LanguageTypes.Count >= y.LanguageTypes.Count;
        }

        public int GetHashCode([DisallowNull] Internship obj)
        {
            return HashCode.Combine(obj.LanguageTypes);
        }
    }
}
