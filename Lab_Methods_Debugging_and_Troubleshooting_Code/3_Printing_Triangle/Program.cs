using System;

namespace _3_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfColumns = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfColumns; i++)
            {
                PrintLine(1, i);
            }
            for (int i = numberOfColumns - 1; i > 0; i--)
            {
                PrintLine(1, i);
            }
        }
        static void PrintLine(int start , int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
