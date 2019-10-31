using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string kewWordPattern = Console.ReadLine();
            string patern = @"[^A-Za-z]" + kewWordPattern + @"[^A-Za-z]";
            string text = Console.ReadLine();
            string[] sentences = text
                .Split(new char[] { '.', '?', '!',}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, patern))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
