using System;

namespace _1_Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Greet(name);
        }
        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        
    }
}
