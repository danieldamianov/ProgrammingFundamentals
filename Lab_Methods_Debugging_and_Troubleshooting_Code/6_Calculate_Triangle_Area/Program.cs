using System;

namespace _6_Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double basa = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetArea(basa,height));
        }
        static double GetArea(double basa, double height)
        {
            return basa * height / 2;
        }
    }
}
