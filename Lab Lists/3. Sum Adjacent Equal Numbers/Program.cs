﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < input.Count - 1; i++)
            {
                if(input[i] == input[i + 1])
                {
                    Double tempSum = input[i] + input[i + 1];
                    input.RemoveAt(i);
                    input.RemoveAt(i);
                    input.Insert(i, tempSum);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
