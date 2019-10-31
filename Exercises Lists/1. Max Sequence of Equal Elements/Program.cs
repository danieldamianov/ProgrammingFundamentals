using System;
using System.Linq;

namespace _1._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int bestStart = 0;
            int currentStart = 0;
            int bestLength = 0;
            int currentLength = 1;
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if(arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(arr[i] == arr[i + 1])
                {
                    currentLength++;
                    if(i == arr.Length - 2)
                    {
                        if (currentLength > bestLength)
                        {
                            bestLength = currentLength;
                            bestStart = currentStart;
                        }
                    }
                }
                else
                {
                    if(currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStart = currentStart;
                    }
                    currentStart = i + 1;
                    currentLength = 1;
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(arr[bestStart] + " ");
                bestStart++;
            }
        }
    }
}
