using System;

namespace _01_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    if (k == i || k == n + 1 - i) Console.Write("x");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
