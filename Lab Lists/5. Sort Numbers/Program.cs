using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToList();
            input.Sort();
            Console.WriteLine(string.Join(" => ",input));
        }
    }
}
