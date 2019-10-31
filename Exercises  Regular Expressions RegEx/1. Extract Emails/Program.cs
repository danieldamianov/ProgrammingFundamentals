using System;
using System.Text.RegularExpressions;

namespace _1._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))[A-Za-z][A-Za-z.\-_]+@\w+([.\-]{1}\w+)+";
            MatchCollection emails = Regex.Matches(text, pattern);
            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
