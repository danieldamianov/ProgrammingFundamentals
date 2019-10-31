using System;
using System.Collections.Generic;

namespace _3._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            string currentResource = Console.ReadLine();
            if (currentResource == "stop") return;
            int currentQuantity = int.Parse(Console.ReadLine());
            while(currentResource != "stop")
            {
                if (resources.ContainsKey(currentResource) == false)
                {
                    resources[currentResource] = 0;
                }
                resources[currentResource] += currentQuantity;
                currentResource = Console.ReadLine();
                if (currentResource == "stop") break;
                currentQuantity = int.Parse(Console.ReadLine());
            }
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
