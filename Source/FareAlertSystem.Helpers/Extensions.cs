using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FareAlertSystem.Helpers
{
    public static class Extensions
    {
        public static IEnumerable<DayOfWeek> ToDaysOfWeek(this string input)
        {
            var pattern = "(S|_)(M|_)(T|_)(W|_)(T|_)(F|_)(S|_)";
            MatchCollection matchCollection = Regex.Matches(input, pattern);

            foreach (Match match in matchCollection)
            {
                foreach (Group group in match.Groups)
                {
                    if (group.Length == 1 && group.Value != "_")
                    {
                        yield return (DayOfWeek)group.Index;
                    }
                }

                break;
            }
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> predicate)
        {
            foreach (var item in collection)
            {
                predicate(item);
            }
        }
    }
}