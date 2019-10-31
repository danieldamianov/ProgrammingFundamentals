using System;

namespace _05_Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double far = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Converting(far):f2}");
        }
        static double Converting (double farenheit)
        {
            double celsius = (farenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
