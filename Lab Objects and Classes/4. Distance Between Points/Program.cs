using System;
using System.Linq;

namespace _4._Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] firstPointArgs = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point firstPoint = new Point(firstPointArgs[0], firstPointArgs[1]);
            double[] secondPointArgs = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point secondPoint = new Point(secondPointArgs[0], secondPointArgs[1]);
            Console.WriteLine("{0:f3}",CalcDist(firstPoint,secondPoint));
        }
        static double CalcDist(Point p1,Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point() { }
        public Point(double first , double second)
        {
            X = first;
            Y = second;
        }
    }
}
