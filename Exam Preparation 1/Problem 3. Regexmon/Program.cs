using System;
using System.Text.RegularExpressions;

namespace Problem_3._Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string didimonPattern = @"[^A-Za-z-]+";
            string bojomonPattern = @"[a-zA-z]+-[a-zA-z]+";
            while (true)
            {
                if (Regex.IsMatch(text,didimonPattern) == false)
                {
                    break;
                }
                Match didiMatch = Regex.Match(text, didimonPattern);
                Console.WriteLine(didiMatch.Value);
                int posOfDidiMatch = didiMatch.Index;
                text = text.Remove(0, posOfDidiMatch + didiMatch.Value.Length);
                if (Regex.IsMatch(text, bojomonPattern) == false)
                {
                    break;
                }
                Match bojoMatch = Regex.Match(text, bojomonPattern);
                Console.WriteLine(bojoMatch.Value);
                int posOfBojoMatch = bojoMatch.Index;
                text = text.Remove(0, posOfBojoMatch + bojoMatch.Value.Length);
            }
        }
    }
}
