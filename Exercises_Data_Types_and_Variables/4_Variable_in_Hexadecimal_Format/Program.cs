using System;

namespace _4_Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int number = Convert.ToInt32(hex, 16);
            Console.WriteLine(number);
        }
    }
}
