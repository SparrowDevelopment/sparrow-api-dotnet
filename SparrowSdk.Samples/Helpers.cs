using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SparrowSdk.Samples
{
    public static class Helpers
    {
        public static string JoinStrings(this IEnumerable<string> items, string delimeter)
        {
            var result = items.Aggregate(new StringBuilder(), (acc, x) => acc.Append(x + delimeter)).ToString();

            if (string.IsNullOrEmpty(result)) { return ""; }
            return result.Substring(0, result.Length - delimeter.Length);
        }
    }
}
