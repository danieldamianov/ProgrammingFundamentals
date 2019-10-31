using System;
using System.Linq;

namespace _3._Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCircleArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondCircleArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point s1Center = new Point(firstCircleArgs[0], firstCircleArgs[1]);
            Point s2Center = new Point(secondCircleArgs[0], secondCircleArgs[1]);
            int s1Radius = firstCircleArgs[2];
            int s2Radius = secondCircleArgs[2];
            Circle firstCircle = new Circle(s1Center, s1Radius);
            Circle secondCircle = new Circle(s2Center, s2Radius);
            if(Circle.Intersect(firstCircle , secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point( int X , int Y)
        {
            this.X = X;
            this.Y = Y;
        } 
        
    }
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Circle(Point center , int radius)
        {
            Center = center;
            Radius = radius;
        }
        public static bool Intersect (Circle s1 , Circle s2)
        {
            double dist = CalcDist(s1.Center, s2.Center);
            if(dist <= s1.Radius + s2.Radius)
            {
                return true;
            }
            return false;
        }
        private static double CalcDist(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
}
