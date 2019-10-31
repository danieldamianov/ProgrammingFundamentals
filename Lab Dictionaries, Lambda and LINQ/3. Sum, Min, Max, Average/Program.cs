using System;
using System.Collections.Generic;
using System.Linq;
namespace _3._Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var arr = new List<int> ();
            for (int i = 0; i < size; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"Sum = {arr.Sum()}");
            Console.WriteLine($"Min = {arr.Min()}");
            Console.WriteLine($"Max = {arr.Max()}");
            Console.WriteLine($"Average = {arr.Average()}");
        }
    }
}
