using System;
using System.Linq;

namespace _2._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[array.Length];
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
            RotateArray(array);
                for (int j = 0; j < array.Length; j++)
                {
                    sum[j] += array[j];
                }
            }
            Console.WriteLine(string.Join(" ",sum));
        }
        static void RotateArray(int[] arr)
        {
            int[] helper = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                helper[i] = arr[i];
            }
            int temp = arr[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = helper[i - 1];
            }
            arr[0] = temp;
        }
    }
}
