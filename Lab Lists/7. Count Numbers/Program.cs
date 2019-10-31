using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();    
            int currentAppearences = 1;
            if(input.Count == 1)
            {
                Console.WriteLine($"{input[0]} -> 1");
                return;
            }
            for (int i = 0; i < input.Count - 1; i++)
            {
                if(input[i] == input[i + 1])
                {
                    currentAppearences++;
                    if (i == input.Count - 2)
                    {
                        Console.WriteLine($"{input[i]} -> {currentAppearences}");
                    }
                }
                else
                {
                    Console.WriteLine($"{input[i]} -> {currentAppearences}");
                    if (i == input.Count - 2)
                    {
                        Console.WriteLine($"{input[i + 1]} -> 1");
                    }
                    currentAppearences = 1;
                }
            }
                
        }
    }
}

