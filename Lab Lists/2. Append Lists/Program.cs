using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { '|' } , StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = input.Count - 1 ; i >= 0; i--)
            {
                List<int> numbers = input[i].Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
