using System;
using System.Linq;

namespace _3._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstRow = new int[input.Length / 2];
            int[] middleRow = new int[input.Length / 2];
            for (int i = input.Length / 4 - 1 , j = 0; i >= 0; i-- , j++)
            {
                firstRow[j] = input[i];
            }
            for (int i = input.Length - 1 , j = firstRow.Length / 2; i >= input.Length / 4 * 3; i-- , j++)
            {
                firstRow[j] = input[i];
            }
            for (int i = input.Length / 4 , j = 0 ; i < input.Length / 4 * 3; i++ , j++)
            {
                middleRow[j] = input[i];
            }
            int[] result = new int[input.Length / 2];
            for (int i = 0; i < input.Length / 2; i++)
            {
                result[i] = firstRow[i] + middleRow[i];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
