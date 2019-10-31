using System;
using System.Linq;
using System.Collections.Generic;
namespace _7._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombNumber = bomb[0];
            int power = bomb[1];
            while (input.IndexOf(bombNumber) != -1)
            {
                try
                {
                    input.RemoveRange(input.IndexOf(bombNumber) + 1, power);
                }
                catch (Exception)
                {
                    input.RemoveRange(input.IndexOf(bombNumber) + 1, input.Count - 1 - input.IndexOf(bombNumber));
                }
                //going to left part
                try
                {
                    input.RemoveRange(input.IndexOf(bombNumber) - power, power + 1);
                }
                catch (Exception)
                {
                    input.RemoveRange(0, input.IndexOf(bombNumber) + 1);
                }
            }
            Console.WriteLine(input.Sum());
        }
    }
}
