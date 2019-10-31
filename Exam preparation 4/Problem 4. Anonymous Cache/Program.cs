using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "thetinggoesskrra")
                {
                    break;
                }
                string[] inputArgs = input.Split(new char[] { ' ', '|', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputArgs.Length == 1)
                {
                    data.Add(inputArgs[0], new Dictionary<string, long>());
                    if (cache.ContainsKey(inputArgs[0]))
                    {
                        foreach (var kvp in cache[inputArgs[0]])
                        {
                            data[inputArgs[0]].Add(kvp.Key, kvp.Value);
                        }
                    }
                    continue;
                }
                string dataSet = inputArgs[2];
                long dataSize = long.Parse(inputArgs[1]);
                string dataKey = inputArgs[0];
                if (data.ContainsKey(dataSet) == false)
                {
                    if (cache.ContainsKey(dataSet) == false)
                    {
                        cache.Add(dataSet, new Dictionary<string, long>());
                    }
                    cache[dataSet].Add(dataKey, dataSize);
                    continue;
                }
                data[dataSet].Add(dataKey, dataSize);
            }
            if (data.Count == 0)
            {
                return;
            }
            data = data.OrderByDescending(x => x.Value.Sum(y => y.Value)).ToDictionary(x => x.Key,x => x.Value);
            var maxElement = data.First();
            var maxElementCount = maxElement.Value.Sum(y => y.Value);
            
            Console.WriteLine($"Data Set: {maxElement.Key}, Total Size: {maxElementCount}");
            foreach (var kvp in maxElement.Value)
            {
                Console.WriteLine($"$.{kvp.Key}");
            }
        }
    }
}
