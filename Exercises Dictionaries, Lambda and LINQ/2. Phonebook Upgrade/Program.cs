using System;
using System.Collections.Generic;

namespace _2._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>();
            string[] commands = Console.ReadLine().Split(' ');
            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    phoneBook[commands[1]] = commands[2];
                }
                else if(commands[0] == "S")
                {
                    if (phoneBook.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"{commands[1]} -> {phoneBook[commands[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {commands[1]} does not exist.");
                    }
                }
                else
                {
                    foreach (var kvp in phoneBook)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
                commands = Console.ReadLine().Split(' ');
            }
        }
    }
}
