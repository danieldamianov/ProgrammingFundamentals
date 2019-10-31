using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new SortedDictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(' ');
            while(input[0] != "end")
            {
                if(server.ContainsKey(string.Join("",input[2].Skip(5))) == false)
                server.Add(string.Join("",input[2].Skip(5)),new Dictionary<string, int>());
                if (server[string.Join("",input[2].Skip(5))].ContainsKey(string.Join("",input[0].Skip(3))) == false)
                {
                    server[string.Join("",input[2].Skip(5))].Add(string.Join("",input[0].Skip(3)), 0);
                }
                server[string.Join("",input[2].Skip(5))][string.Join("",input[0].Skip(3))]++;
                input = Console.ReadLine().Split(' ');

            }
            foreach (var user in server)
            {
                var output = new List<string>();
                Console.WriteLine(user.Key + ":");
                foreach (var ip in user.Value)
                {
                    output.Add(ip.Key + " => " + ip.Value);
                }
                Console.Write(string.Join(", ",output));
                Console.WriteLine(".");
            }
        }
    }
}
