using System;

namespace _6_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            if (isPrime(number))
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
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
