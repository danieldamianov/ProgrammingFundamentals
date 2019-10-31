using System;
using System.Linq;

namespace _5._Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] PointsArray = new Point[n];
            for (int i = 0; i < n; i++)
            {
                double[] currentPointArgs = Console.ReadLine().Split().Select(double.Parse).ToArray();
                PointsArray[i] = new Point(currentPointArgs[0], currentPointArgs[1]);
            }
            Console.WriteLine("{0:f3}",CalcDist(FindTwoClosest(PointsArray)[0], FindTwoClosest(PointsArray)[1]));
            Console.WriteLine("(" + FindTwoClosest(PointsArray)[0].X + ", " + FindTwoClosest(PointsArray)[0].Y + ")");
            Console.WriteLine("(" + FindTwoClosest(PointsArray)[1].X + ", " + FindTwoClosest(PointsArray)[1].Y + ")");
        }
        static Point[] FindTwoClosest(Point[] points)
        {
            Point[] closestPoints = new Point[2];
            double minDist = double.MaxValue;
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    if(CalcDist(points[i],points[j]) < minDist)
                    {
                        minDist = CalcDist(points[i], points[j]);
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }
            return closestPoints;
        }
        static double CalcDist(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point() { }
        public Point(double first, double second)
        {
            X = first;
            Y = second;
        }
    }
}
