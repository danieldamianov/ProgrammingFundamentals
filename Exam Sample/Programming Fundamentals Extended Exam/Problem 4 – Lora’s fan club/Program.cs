using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4___Lora_s_fan_club
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> boys = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string[] inputArgs = Console.ReadLine().Split(' ');
                if (inputArgs.Length == 4)
                {
                    break;
                }
                if (inputArgs[2].EndsWith('!') == false)
                {
                    string name = inputArgs[0];
                    string trait = inputArgs[1];
                    int value = int.Parse(inputArgs[2]);
                    if (boys.ContainsKey(name) == false)
                    {
                        boys.Add(name, new Dictionary<string, int>());
                    }
                    if (trait == "Greedy" || trait == "Rude" || trait == "Dumb")
                    {
                        value *= -1;
                    }
                    else if(trait == "Kind")
                    {
                        value *= 2;
                    }
                    else if (trait == "Handsome")
                    {
                        value *= 3;
                    }
                    else if (trait == "Smart")
                    {
                        value *= 5;
                    }
                    if (boys[name].ContainsKey(trait))
                    {
                        if (boys[name][trait] < value)
                        {
                            boys[name][trait] = value;
                        }
                    }
                    else
                    {
                        boys[name].Add(trait, value);
                    }
                }
                else
                {
                    string name = inputArgs[0];
                    if (boys.ContainsKey(name))
                    {
                        List<string> list = new List<string>();
                        foreach (var trait in boys[name])
                        {
                            if (trait.Value > 0)
                            {
                                list.Add(trait.Key);
                            }
                        }
                        foreach (var item in list)
                        {
                            boys[name].Remove(item);
                        }
                    }
                }
            }
            foreach (var boy in boys.OrderByDescending(x => x.Value.Sum(y => y.Value)).ThenBy(x => x.Key))
            {
                Console.WriteLine($"# {boy.Key}: {boy.Value.Sum(y => y.Value)}");
                foreach (var trait in boy.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"!!! {trait.Key} -> {trait.Value}");
                }
            }
        }
    }
}
