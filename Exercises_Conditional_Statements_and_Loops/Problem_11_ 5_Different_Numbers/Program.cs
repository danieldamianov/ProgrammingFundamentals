using System;

namespace Problem_11__5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            if((end - start) < 5)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = start; i <= end - 4; i++)
            {
                for (int j = i+1; j <= end - 3; j++)
                {
                    for (int k = j+1; k <= end - 2; k++)
                    {
                        for (int m = k+1 ; m <= end - 1; m++)
                        {
                            for (int n = m + 1; n <= end; n++)
                            {
                                Console.WriteLine($"{i} {j} {k} {m} {n}");
                            }
                        }
                    }
                }
            }
        }
    }
}
