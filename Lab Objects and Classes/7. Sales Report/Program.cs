using System;
using System.Collections.Generic;

namespace _7._Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            var towns = new SortedDictionary<string, decimal>();
            decimal numberOfSales = decimal.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfSales; i++)
            {
                string[] currentSale = Console.ReadLine().Split(' ');
                if(towns.ContainsKey(currentSale[0]) == false)
                {
                    towns.Add(currentSale[0], 0m);
                }
                towns[currentSale[0]] += decimal.Parse(currentSale[2]) * decimal.Parse(currentSale[3]);
            }
            foreach (var town in towns)
            {
                Console.WriteLine("{0} -> {1:f2}", town.Key, town.Value);
            }
        }
    }
}
