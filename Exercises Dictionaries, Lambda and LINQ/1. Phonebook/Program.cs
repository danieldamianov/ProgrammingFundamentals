using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();
            string[] commands = Console.ReadLine().Split(' ');
            while(commands[0] != "END")
            {
                if(commands[0] == "A")
                {
                    phoneBook[commands[1]] = commands[2];
                }
                else
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
                commands = Console.ReadLine().Split(' ');
            }
        }
    }
}
