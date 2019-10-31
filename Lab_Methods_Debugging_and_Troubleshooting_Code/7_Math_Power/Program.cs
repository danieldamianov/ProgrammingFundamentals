using System;

namespace _7_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Power(double.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));
        }
        static double Power(double number , int power)
        {
            double sum = 1;
            for (int i = 0; i < power; i++)
            {
                sum *= number;
            }
            return sum;
        }
    }
}
