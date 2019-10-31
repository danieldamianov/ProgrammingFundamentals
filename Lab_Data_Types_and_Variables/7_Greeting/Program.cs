using System;

namespace _7_Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {first} {second}. You are {age} years old.");
        }
    }
}
