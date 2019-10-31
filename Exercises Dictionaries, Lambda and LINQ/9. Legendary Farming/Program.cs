using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            var keyElements = new Dictionary<string, int>()
            {
                {"shards" , 0 },
                {"fragments" , 0 },
                {"motes" , 0 },
            };
            var junkElements = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ');
                for (int i = 0; i < input.Length; i+=2)
                {
                    if (keyElements.ContainsKey(input[i + 1]))
                    {
                        keyElements[input[i + 1]] += int.Parse(input[i]);
                        if (keyElements[input[i + 1]] >= 250)
                        {
                            flag = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junkElements.ContainsKey(input[i + 1]) == false)
                        {
                            junkElements[input[i + 1]] = 0;
                        }
                        junkElements[input[i + 1]] += int.Parse(input[i]);
                    }
                }
                if (flag == true) break;
            }
            if(keyElements["shards"] >= 250)
            {
                Console.WriteLine($"Shadowmourne obtained!");
                keyElements["shards"] -= 250;
            }            
            else if (keyElements["fragments"] >= 250)
            {
                Console.WriteLine($"Valanyr obtained!");
                keyElements["fragments"] -= 250;
            }
            else if (keyElements["motes"] >= 250)
            {
                Console.WriteLine($"Dragonwrath obtained!");
                keyElements["motes"] -= 250;
            }
            keyElements = keyElements
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var legend in keyElements)
            {
                Console.WriteLine($"{legend.Key}: {legend.Value}");
            }
            junkElements = junkElements
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key , x => x.Value);
            foreach (var junk in junkElements)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
