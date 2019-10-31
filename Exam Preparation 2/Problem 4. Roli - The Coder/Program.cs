using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_4._Roli___The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<string, List<string>>> events = new Dictionary<string, KeyValuePair<string, List<string>>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }
                string pattern = @"[A-Za-z0-9\'\-]+\s+#[A-Za-z]+(\s+@[A-Za-z0-9'-]+)*";
                if (Regex.IsMatch(input,pattern) == false)
                {
                    continue;
                }
                string[] eventArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string id = eventArgs[0];
                string teamName = eventArgs[1].Remove(0, 1);
                List<string> namesOfParticipants = eventArgs.Skip(2).ToList();
                //Console.WriteLine(id);
                //Console.WriteLine(teamName);
                //Console.WriteLine(string.Join(" ",namesOfParticipants));
                if (events.ContainsKey(id))
                {
                    if (events[id].Key != teamName)
                    {
                        continue;
                    }
                    events[id].Value.AddRange(namesOfParticipants);
                }
                else if(events.Any(x => x.Value.Key == teamName) == false)
                {
                    events.Add(id, new KeyValuePair<string, List<string>>(teamName,namesOfParticipants));
                }
            }
            foreach (var id in events.OrderByDescending(x => x.Value.Value.Distinct().Count()).ThenBy(x => x.Value.Key))
            {
                Console.WriteLine($"{id.Value.Key} - {id.Value.Value.Distinct().Count()}");
                foreach (var part in id.Value.Value.Distinct().OrderBy(x => x))
                {
                    Console.WriteLine(part);
                }
            }
        }
    }
}
