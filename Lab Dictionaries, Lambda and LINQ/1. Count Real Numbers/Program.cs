using System;
using System.Collections.Generic;
using System.Linq;
namespace _1._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            var numApperances = new SortedDictionary<double, int>();
            foreach (var num in input)
            {
                if (!numApperances.ContainsKey(num))
                {
                    numApperances[num] = 0;
                }
                numApperances[num]++;
            }
            foreach (var kvp in numApperances)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}