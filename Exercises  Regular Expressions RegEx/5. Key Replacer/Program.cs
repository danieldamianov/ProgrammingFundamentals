using System;
using System.Text.RegularExpressions;
using System.Text;

namespace _5._Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string endWord = "";
            string startWord = "";
            string keyString = Console.ReadLine();
            string mainString = Console.ReadLine();
            if(Regex.IsMatch(keyString, @"^\w+(?=[\\<\|])"))
            {
                startWord = Regex.Match(keyString, @"^\w+(?=[\\<\|])").Value;
            }
            if(Regex.IsMatch(keyString, @"(?<=[<\|\\])\w+$"))
            {
                endWord = Regex.Match(keyString, @"(?<=[<\|\\])\w+$").Value;
            }
            MatchCollection matches = Regex.Matches(mainString, $@"(?<={startWord})(?<key>.*?)(?={endWord})");
            StringBuilder output = new StringBuilder();
            foreach (Match match in matches)
            {
                output.Append(match.Groups["key"].Value);
            }
            if(output.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(output.ToString());
            }
        }
    }
}
