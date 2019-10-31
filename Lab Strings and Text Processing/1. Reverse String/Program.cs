using System;

namespace _1._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] textChar = text.ToCharArray();
            Array.Reverse(textChar);
            Console.WriteLine(textChar);
        }
    }
}
