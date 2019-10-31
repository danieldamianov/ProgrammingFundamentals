using System;
using System.Numerics;
namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger numberFactored = Fact(n);
            int counterr = 0;
            while (true)
            {
                if (numberFactored % 10 == 0)
                {
                    counterr++;
                    numberFactored /= 10;
                }
                else break;
            }
            Console.WriteLine(counterr);
        }
        static BigInteger Fact(int n)
        {
            BigInteger fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
