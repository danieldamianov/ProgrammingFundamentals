using System;

namespace _9_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvens(number) * GetSumOfOdds(number);
        }
        static int GetSumOfEvens(int number)
        {
            int sum = 0;
            while(number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetSumOfOdds(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
