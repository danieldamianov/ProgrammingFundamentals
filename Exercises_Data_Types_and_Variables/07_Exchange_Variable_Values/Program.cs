using System;

namespace _07_Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before:\na = {a}\nb = {b}");
            int swap = a;
            a = b;
            b = swap;
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
