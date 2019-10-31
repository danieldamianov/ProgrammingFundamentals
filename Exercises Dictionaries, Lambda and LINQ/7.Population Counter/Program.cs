using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var populations = new Dictionary< string, Dictionary<string, long> >();
            string[] currentCity = Console.ReadLine().Split('|');
            while(currentCity[0] != "report")
            {
                if(populations.ContainsKey(currentCity[1]) == false)
                {
                    populations.Add(currentCity[1], new Dictionary<string, long>());
                }
                populations[currentCity[1]].Add(currentCity[0],long.Parse(currentCity[2]));
                populations[currentCity[1]] = populations[currentCity[1]]
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);
                currentCity = Console.ReadLine().Split('|');
            }
            populations = populations
                .OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x => x.Key , x => x.Value);

            foreach (var country in populations)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var town in country.Value)
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }
            }
        }
    }
}
