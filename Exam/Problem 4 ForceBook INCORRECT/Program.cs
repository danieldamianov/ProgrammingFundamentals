using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ForceBook //90%
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"(?<first>.+)(?<middle> \| | \-> )(?<second>.+)";
        var forceBook = new Dictionary<string, List<string>>();

        while (input != "Lumpawaroo")
        {
            Match tokens = Regex.Match(input, pattern);


            string delimiter = tokens.Groups["middle"].Value.Trim();
            string forceUser = "";
            string forceSide = "";


            if (delimiter == "|")
            {
                forceUser = tokens.Groups["second"].Value;
                forceSide = tokens.Groups["first"].Value;

                if (forceBook.ContainsKey(forceSide) == false)
                {
                    forceBook.Add(forceSide, new List<string>());
                }

                if (forceBook[forceSide].Contains(forceUser) == false)
                {
                    forceBook[forceSide].Add(forceUser);
                }
            }
            else if (delimiter == "->")
            {
                forceUser = tokens.Groups["first"].Value;
                forceSide = tokens.Groups["second"].Value;

                foreach (var record in forceBook)
                {
                    if (record.Value.Contains(forceUser))
                    {
                        record.Value.Remove(forceUser);
                    }
                }

                if (forceBook.ContainsKey(forceSide) == false)
                {
                    forceBook.Add(forceSide, new List<string>());
                }

                forceBook[forceSide].Add(forceUser);
                Console.WriteLine($"{forceUser} joins the {forceSide} side!");
            }

            input = Console.ReadLine();
        }

        foreach (var record in forceBook.Where(f => f.Value.Count > 0).OrderByDescending(f => f.Value.Count).ThenBy(f => f.Key))
        {
            Console.WriteLine($"Side: {record.Key}, Members: {record.Value.Count}");

            foreach (string user in record.Value.OrderBy(u => u))
            {
                Console.WriteLine($"! {user}");
            }
        }
    }
}