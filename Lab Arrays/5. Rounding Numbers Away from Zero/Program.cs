using System;
using System.Linq;

namespace _5._Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                var newItem = Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {newItem}");
            }
        }
    }
}
