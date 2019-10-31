using System;

namespace Problem_4_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            if (start > end)
            {
                int swap = end;
                end = start;
                start = swap;
            }
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}