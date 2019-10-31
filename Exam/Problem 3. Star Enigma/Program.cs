using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_3._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                int counter = 0;
                foreach (char symbol in message)
                {
                    if (symbol == 't'||
                        symbol == 'T' ||
                        symbol == 's' ||
                        symbol == 'S' ||
                        symbol == 'a' ||
                        symbol == 'A' ||
                        symbol == 'r' ||
                        symbol == 'R' )
                    {
                        counter++;
                    }
                }
                StringBuilder mes = new StringBuilder();
                foreach (char symbol in message)
                {
                    mes.Append((char)(symbol - counter));
                }
                message = mes.ToString();
                string planetPattern = @"@([a-zA-Z]+)";
                //string populationPattern = @":[0-9]+";
                string typePattern = @"!(A|D)!";
                //string soldierPattern = @"->[0-9]+";
                string pattern = @"@([a-zA-Z]+)[^@\-!:>]*:[0-9]+[^@\-!:>]*!(A|D)![^@\-!:>]*->[0-9]+";
                //check ORDER!!!
                if (Regex.IsMatch(message, pattern))
                {
                    if (Regex.Match(message, typePattern).Groups[1].Value == "D")
                    {
                        destroyed.Add(Regex.Match(message, planetPattern).Groups[1].Value);
                    }
                    else
                    {
                        attacked.Add(Regex.Match(message, planetPattern).Groups[1].Value);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var planet in attacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var planet in destroyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
