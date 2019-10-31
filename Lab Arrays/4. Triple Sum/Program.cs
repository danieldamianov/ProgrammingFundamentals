using System;
using System.Linq;

namespace _4._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sumExists = false;
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    foreach (var item in arr)
                    {
                        if(sum == item)
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} == {item}");
                            sumExists = true;
                            break;
                        }
                    }

                }
            }
            if (!sumExists)
            {
                Console.WriteLine("No");
            }
        }
    }
}
