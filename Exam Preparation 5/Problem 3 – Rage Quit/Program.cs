using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_3___Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"([^0-9]+)([0-9]+)";
            string line = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            MatchCollection matches = Regex.Matches(line, regex);
            foreach (Match match in matches)
            {
                for (int i = 0; i < int.Parse(match.Groups[2].Value); i++)
                {
                    output.Append(match.Groups[1].Value.ToUpper());
                }
            }
            Console.WriteLine(value: $"Unique symbols used: {output.ToString().Distinct().Count()}");
            Console.WriteLine(output.ToString());
        }
    }
}
