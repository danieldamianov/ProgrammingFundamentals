using System;

namespace _11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{TriangleArea(side , height):f2}");
            }
            else if (type == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{RectangleArea(width, height):f2}");
            }
            else if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{SquareArea(side):f2}");
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CircleArea(radius):f2}");
            }
        }

        static double CircleArea(double radius)
        {
            return radius * radius * Math.PI;
        }

        static double SquareArea(double side)
        {
            return side * side;
        }

        static double RectangleArea(double width, double height)
        {
            return width * height; 
        }

        static double TriangleArea(double side , double height)
        {
            return side * height / 2;
        }
    }
}
