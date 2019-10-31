using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emalsDict = new Dictionary<string, string>();
            string email = "";
            string name = Console.ReadLine();
            if(name != "stop")
            {
                email = Console.ReadLine();
                emalsDict[name] = email;
            }
            while(name != "stop")
            {
                emalsDict[name] = email;
                name = Console.ReadLine();
                if (name == "stop") break;
                email = Console.ReadLine();
            }
            
            emalsDict = emalsDict
                .Where(x => !x.Value.EndsWith("us") && !x.Value.EndsWith("uk"))
                .ToDictionary(x => x.Key , x => x.Value);
            foreach (var kvp in emalsDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
