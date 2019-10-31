using System;

namespace _13_Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            if(symbol>=48 && symbol <= 57)
            {
                Console.WriteLine("digit");
            }
            else if(symbol == 97 || symbol == 101 || symbol == 105 || symbol == 111 || symbol == 117)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
