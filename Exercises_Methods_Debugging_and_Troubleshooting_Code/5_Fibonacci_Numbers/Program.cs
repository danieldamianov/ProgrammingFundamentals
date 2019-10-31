using System;

namespace _5_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(number));
        }
        static int Fib (int number)
        {
            int FirstNum = 1;
            int SecondNum = 1;
            int Sum = 0;
            if (number < 2) return 1;
            for (int i = 1; i < number; i++)
            {
                Sum = FirstNum + SecondNum;
                FirstNum = SecondNum;
                SecondNum = Sum;
            }
            return Sum;
        }
    }
}
