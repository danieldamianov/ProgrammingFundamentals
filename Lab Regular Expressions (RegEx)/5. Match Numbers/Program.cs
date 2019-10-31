using System;
using System.Text.RegularExpressions;

namespace _5._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            Regex regex = new Regex(pattern);
            MatchCollection numbers = Regex.Matches(text, pattern);
            foreach (Match num in numbers)
            {
                Console.WriteLine(num.Value + " ");
            }
        }
    }
}
