using System;

namespace _9._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1fX = double.Parse(Console.ReadLine());
            double l1fY = double.Parse(Console.ReadLine());
            double l1sX = double.Parse(Console.ReadLine());
            double l1sY = double.Parse(Console.ReadLine());
            double l2fX = double.Parse(Console.ReadLine());
            double l2fY = double.Parse(Console.ReadLine());
            double l2sX = double.Parse(Console.ReadLine());
            double l2sY = double.Parse(Console.ReadLine());
            double firstLegth = Math.Sqrt(Math.Abs(l1fX - l1sX) * Math.Abs(l1fX - l1sX) + Math.Abs(l1fY - l1sY) * Math.Abs(l1fY - l1sY));
            double secondLegth = Math.Sqrt(Math.Abs(l2fX - l2sX) * Math.Abs(l2fX - l2sX) + Math.Abs(l2fY - l2sY) * Math.Abs(l2fY - l2sY));
            if(firstLegth >= secondLegth)
            {
                PrintPoint(l1fX, l1fY, l1sX, l1sY);
            }
            else
            {
                PrintPoint(l2fX, l2fY, l2sX, l2sY);
            }
        }

        static void PrintPoint(double firstX, double secondX, double firstY, double secondY)
        {
            double distX = Math.Sqrt(Math.Abs(firstX) * Math.Abs(firstX) + Math.Abs(secondX) * Math.Abs(secondX));
            double distY = Math.Sqrt(Math.Abs(firstY) * Math.Abs(firstY) + Math.Abs(secondY) * Math.Abs(secondY));
            if (distX <= distY)
            {
                Console.WriteLine($"({firstX}, {secondX})({firstY}, {secondY})");
            }
            else
            {
                Console.WriteLine($"({firstY}, {secondY})({firstX}, {secondX})");
            }
        }
    }
}
