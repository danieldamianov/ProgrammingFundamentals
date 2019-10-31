using System;

namespace _6._Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            for (int i = 0; i < arr.Length  / 2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            foreach (var item in arr)
            {
                Console.Write(item + ' ');
            }
            Console.WriteLine();
        }
    }
}
