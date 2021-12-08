using BL.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BL.EqualityComparers
{
    public class LocationDTOEqualityComparer : IEqualityComparer<CountryDTO>
    {
        public bool Equals(CountryDTO x, CountryDTO y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;

            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] CountryDTO obj)
        {
            return HashCode.Combine(obj.Id, obj.Name);
        }

    }
}
