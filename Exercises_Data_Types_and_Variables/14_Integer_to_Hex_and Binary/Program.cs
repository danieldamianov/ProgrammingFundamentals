using System;

namespace _14_Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string toBinary = Convert.ToString(n,2);
            string toHex = Convert.ToString(n,16);
            Console.WriteLine(toHex.ToUpper());
            Console.WriteLine(toBinary);
        }
    }
}
