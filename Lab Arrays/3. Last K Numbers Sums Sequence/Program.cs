using System;

namespace _3._Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] seq = new long[n];
            seq[0] = 1;
            if (k == 0)
            {
                Console.Write(1 + " ");
                for (int i = 1; i < n; i++)
                {
                    Console.Write(0 + " ");
                }
                return;
            }
            for (int i = 1; i < n; i++)
            {
                int counter = 0;
                long sum = 0;
                for (int j = i - 1; j >=0 ; j--)
                {
                    counter++;
                    sum += seq[j];
                    if(counter >= k)
                    {
                        break;
                    }
                }
                seq[i] = sum;
            }
            Console.WriteLine(string.Join(" ",seq));
        }
    }
}
