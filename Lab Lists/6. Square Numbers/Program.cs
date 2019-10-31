using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareRoots = new List<int>();
            foreach (var num in input)
            {
                if(Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squareRoots.Add(num);
                }
            }
            squareRoots.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",squareRoots));
        }
    }
}
