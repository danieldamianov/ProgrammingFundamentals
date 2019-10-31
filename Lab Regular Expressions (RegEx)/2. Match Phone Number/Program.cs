using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\+359( |-)2\1\d{3}\1\d{4}\b");
            string text = Console.ReadLine();
            MatchCollection matches = pattern.Matches(text);
            string[] matchesArray = matches.Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ",matchesArray));
        }
    }
}
