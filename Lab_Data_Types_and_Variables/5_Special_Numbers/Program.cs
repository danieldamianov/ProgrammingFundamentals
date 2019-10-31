using System;

namespace _4_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                bool isSpecial = false;
                int digits = i;
                int sum = 0;
                while (digits != 0)
                {
                    sum += digits % 10;
                    digits /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11) isSpecial = true;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
