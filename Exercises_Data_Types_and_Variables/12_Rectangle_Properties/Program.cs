using System;

namespace _12_Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double perimeter = width * 2 + length * 2;
            double area = width * length;
            double diagonal = Math.Sqrt(width * width + length * length);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
