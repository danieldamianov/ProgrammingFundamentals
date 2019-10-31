using System;
using System.Linq;

namespace _6._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int k = arr.Length / 4;
            int[] leftPart = arr.Take(k).Reverse().ToArray();
            int[] rightPart = arr.Reverse().Take(k).ToArray();
            int[] firstRow = leftPart.Concat(rightPart).ToArray();
            int[] secondRow = arr.Skip(k).Take(2 * k).ToArray();
            /*int[] sumArr = new int[2 * k];
            for (int i = 0; i < 2 * k; i++)
            {
                sumArr[i] = firstRow[i] + secondRow[i];
            }*/
            int[] sumArr = firstRow.Select((x,index) => x + secondRow[index]).ToArray();
            Console.WriteLine(string.Join(" ",sumArr));
        }
    }
}
