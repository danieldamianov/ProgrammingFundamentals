using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exists = false;
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j= 0; j < i; j++)
                {
                    leftSum += input[j];
                }
                for (int k = i+1; k < input.Length; k++)
                {
                    rightSum += input[k];
                }
                if(leftSum == rightSum)
                {
                    exists = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (!exists)
            {
                Console.WriteLine("no");
            }
        }
    }
}
