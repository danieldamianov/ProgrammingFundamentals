using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while(nums.Length != 1)
            {
                int[] container = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    container[i] = nums[i] + nums[i + 1];
                }
                nums = container;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
