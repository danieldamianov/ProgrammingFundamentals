using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                char[] helper = input[i].ToCharArray();
                Array.Reverse(helper);
                input[i] = new string (helper);
            }
            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
