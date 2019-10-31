using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _4._Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Weather> towns = new Dictionary<string, Weather>();
            string input = Console.ReadLine();
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)(?=\|)";
            while (input != "end")
            {
               
                if (Regex.IsMatch(input,pattern))
                {
                    Match currentTown = Regex.Match(input, pattern);
                    if(towns.ContainsKey(currentTown.Groups[1].Value) == false)
                    {
                        towns.Add(currentTown.Groups[1].Value, new Weather());
                    }
                    towns[currentTown.Groups[1].Value].Value = double.Parse(currentTown.Groups[2].Value);
                    towns[currentTown.Groups[1].Value].Type = currentTown.Groups[3].Value;
                }
                input = Console.ReadLine();
            }
            foreach (var town in towns.OrderBy(x => x.Value.Value))
            {
                Console.WriteLine($"{town.Key} => {town.Value.Value} => {town.Value.Type}");
            }
        }
    }
    class Weather
    {
        public double Value { get; set; }
        public string Type { get; set; }
    }
}
