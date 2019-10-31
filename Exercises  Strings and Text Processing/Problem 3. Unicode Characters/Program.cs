using System;

namespace Problem_3._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach (var @char in text)
            {
                Console.Write($"\\u{(int)@char:x4}");
            }
        }
    }
}
