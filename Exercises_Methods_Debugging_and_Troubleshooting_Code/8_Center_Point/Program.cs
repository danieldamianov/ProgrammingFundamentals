using System;

namespace _8_Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double fY = double.Parse(Console.ReadLine());
            double sY = double.Parse(Console.ReadLine());
            double fX = double.Parse(Console.ReadLine());
            double sX = double.Parse(Console.ReadLine());
            PrintPoint(fX, sX, fY, sY);
        }
        static void PrintPoint (double firstX , double secondX , double firstY , double secondY)
        {
            double distX = Math.Sqrt(Math.Abs(firstX)* Math.Abs(firstX) + Math.Abs(secondX)* Math.Abs(secondX));
            double distY = Math.Sqrt(Math.Abs(firstY)* Math.Abs(firstY) + Math.Abs(secondY)* Math.Abs(secondY));
            if(distX <= distY)
            {
                Console.WriteLine($"({firstX}, {secondX})");
            }
            else
            {
                Console.WriteLine($"({firstY}, {secondY})");
            }
        }
    }
}
