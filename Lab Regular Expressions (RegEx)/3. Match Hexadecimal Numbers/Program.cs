using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _3._Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\b(0x)?[0-9A-F]{1,}\b");
            string text = Console.ReadLine();
            MatchCollection hexes = Regex.Matches(text,pattern.ToString());
            string[] hexesArray = hexes.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(" ",hexesArray));
        }
    }
}
