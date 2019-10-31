using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input = input.OrderByDescending(x => x).ToList();
            input = input.Take(3).ToList();
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
