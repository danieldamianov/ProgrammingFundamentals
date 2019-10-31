using System;
using System.Linq;

namespace _7._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = new int[Math.Max(firstArr.Length , secondArr.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
