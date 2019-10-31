using System;
using System.Linq;

namespace _2._Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
