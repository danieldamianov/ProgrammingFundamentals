using System;

namespace Problem_14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firts = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            for( char i = firts; i <= second; i++)
            {
                for (char m = firts; m <= second; m++)
                {
                    for (char p = firts; p <= second; p++)
                    {
                        if (i != third && m != third && p != third) Console.Write($"{i}{m}{p} ");
                    }
                }
            }
        }
    }
}
