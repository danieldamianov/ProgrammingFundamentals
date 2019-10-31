using System;

namespace _6_Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letter = (char)('a' + n - 1);
            Console.WriteLine(letter);
            for (char i = 'a'; i <= letter; i++)
            {
                for (char m = 'a'; m <= letter; m++)
                {
                    for (char k = 'a'; k <= letter; k++)
                    {
                        Console.WriteLine($"{i}{m}{k}");
                    }
                }
            }
        }
    }
}
