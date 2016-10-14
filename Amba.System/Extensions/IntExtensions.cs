using System.Collections.Generic;
using System.Linq;

namespace Amba.System.Extensions
{
    public static class IntExtensions
    {
        public static bool IsLessThen(this int value, params int[] otherNumbers)
        {
            return otherNumbers.All(number => number < value);
        }

        public static bool IsLessThen(this int value, IEnumerable<int> otherNumbers)
        {
            return otherNumbers.All(number => number < value);
        }
    }
}
