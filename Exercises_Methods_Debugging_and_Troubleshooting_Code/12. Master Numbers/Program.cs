using System;
namespace _12._Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            for (int current = 1; current <= end; current++)
            {
                if (evenDigit(current) && isPalindrom(current) && istsDigitsAreDivisebleBy7(current))
                {
                    Console.WriteLine(current);
                }
            }
        }
        static bool evenDigit(int number)
        {
            while(number != 0)
            {
                if((number%10)%2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
        static bool isPalindrom(int number)
        {
            int oldNumber = number;
            int reverse = 0;
            while (number != 0)
            {
                reverse *= 10;
                reverse += number % 10;
                number /= 10;
            }
            if(reverse == oldNumber)
            {
                return true;
            }
            return false;
        }
        static bool istsDigitsAreDivisebleBy7(int number)
        {
            int sum = 0;
            while(number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if(sum % 7 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
