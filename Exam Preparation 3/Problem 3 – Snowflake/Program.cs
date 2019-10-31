using System;
using System.Text.RegularExpressions;

namespace Problem_3___Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string surfacePattern = @"^[^a-zA-Z0-9]+$";
            string mantlePattern = @"^[0-9_]+$";
            string middleLinePattern = @"^[^a-zA-Z0-9]+[0-9_]+(?<core>[a-zA-Z]+)[0-9_]+[^a-zA-Z0-9]+$"; //check next pattern
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string middleLine = Console.ReadLine();
            string fourthLine = Console.ReadLine();
            string fifthLine = Console.ReadLine();
            
            if (Regex.IsMatch(firstLine, surfacePattern) &&
                Regex.IsMatch(secondLine, mantlePattern) &&
                Regex.IsMatch(middleLine, middleLinePattern) &&
                Regex.IsMatch(fourthLine, mantlePattern) &&
                Regex.IsMatch(fifthLine, surfacePattern) 
                )
            {
                Console.WriteLine("Valid");
                Console.WriteLine(Regex.Match(middleLine, middleLinePattern)
                    .Groups["core"]
                    .Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
