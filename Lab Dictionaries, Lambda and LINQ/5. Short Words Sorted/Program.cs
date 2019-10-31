using System;
using System.Linq;

namespace _5._Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(".,:;()[]\"\'\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToArray();
            input = input.Where(x => x.Length < 5).ToArray();
            input = input.OrderBy(x => x).ToArray();
            input = input.Distinct().ToArray();
            Console.WriteLine(string.Join(", ",input));
        }
    }
}
