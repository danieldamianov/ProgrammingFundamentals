using System;
using System.Collections.Generic;
using System.Linq;
namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');
            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if(dict.ContainsKey(word) == false)
                {
                    dict[word] = 0;
                }
                dict[word]++;
            }
            var output = new List<string>();
            foreach (var kvp in dict)
            {
                if(kvp.Value % 2 == 1)
                {
                    output.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ",output));
        }
    }
}
