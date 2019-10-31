using System;

namespace Problem2_Choose_a_Drink_2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            switch (profession)
            {
                case "Athlete":
                    quantity *= 0.7;
                    Console.WriteLine($"The {profession} has to pay {quantity:f2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    quantity *= 1;
                    Console.WriteLine($"The {profession} has to pay {quantity:f2}.");
                    break;
                case "SoftUni Student":
                    quantity *= 1.7;
                    Console.WriteLine($"The {profession} has to pay {quantity:f2}.");
                    break;
                default:
                    quantity *= 1.2;
                    Console.WriteLine($"The {profession} has to pay {quantity:f2}.");
                    break;
            }

        }
    }
}
