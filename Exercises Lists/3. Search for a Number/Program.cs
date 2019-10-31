using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            int[] commands = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            List<int> taked = new List<int>();
            for (int i = 0; i < commands[0]; i++)
            {
                taked.Add(input[i]);
            }
            //Console.WriteLine(string.Join(" ",taked));
            taked.RemoveRange(0,commands[1]);
            //Console.WriteLine(string.Join(" ", taked));
            if (taked.Contains(commands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
