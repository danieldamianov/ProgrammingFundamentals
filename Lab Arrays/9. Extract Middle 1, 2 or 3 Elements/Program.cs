using System;
using System.Linq;

namespace _9._Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            TrimElements(nums);
        }
        static void TrimElements(int[] arr)
        {
            if(arr.Length == 1)
            {
                Console.WriteLine($"{{ { arr[0] } }}");
                return;
            }
            if(arr.Length %2 == 0)
            {
                Console.WriteLine($"{{ {arr[arr.Length/2 - 1]}, {arr[arr.Length / 2]} }}");
                return;
            }
            if(arr.Length % 2 == 1)
            {
                Console.WriteLine($"{{ {arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}, {arr[arr.Length / 2 + 1]} }}");
                return;
            }
        }
    }
}
