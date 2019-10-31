using System;

namespace _7_Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            PrintPrimes(start , end);
        }
        static void PrintPrimes(int start , int end)
        {
            int counter = 0;
            for (int current = start; current <= end; current++)
            {
                if (isPrime(current))
                {
                    counter++;
                }
            }
            int helper = 0;
            for (int current = start; current <= end; current++)
            {
                if (isPrime(current))
                {
                    helper++;
                    Console.Write(current);
                    if (helper == counter) Console.Write(" ");
                    else Console.Write(", ");
                }
            }
        }
        static bool isPrime(long number)
        {
            if (number < 2) return false;
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
