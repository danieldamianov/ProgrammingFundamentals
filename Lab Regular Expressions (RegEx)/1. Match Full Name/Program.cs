using System;
using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\b[A-Z][a-z]{1,100} [A-Z][a-z]{1,100}\b");
            string text = Console.ReadLine();
            MatchCollection names = pattern.Matches(text);
            foreach (Match name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}
