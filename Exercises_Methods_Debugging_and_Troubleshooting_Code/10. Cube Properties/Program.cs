using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            if (command == "face")
            {
                Console.WriteLine($"{GetFaceDiagonal(side):f2}");

            }
            else if(command == "space")
            {
                Console.WriteLine($"{GetSpaceDiagonal(side):f2}");
            }
            else if(command == "volume")
            {
                Console.WriteLine($"{GetVolume(side):f2}");
            }
            else
            {
                Console.WriteLine($"{GetArea(side):f2}");
            }
        }

        static double GetArea(double side)
        {
            return 6 * side * side;
        }

        static double GetFaceDiagonal(double side)
        {
            return Math.Sqrt(2 * side * side);
        }
        static double GetSpaceDiagonal(double side)
        {
            return Math.Sqrt(3 * side * side);
        }
        static double GetVolume(double side)
        {
            return side * side * side;
        }
    }
}
