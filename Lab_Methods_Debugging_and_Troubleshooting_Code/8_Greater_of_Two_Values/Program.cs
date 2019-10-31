using System;

namespace _8_Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }
        }
        static char GetMax(char first , char second)
        {
            if(first > second)
            {
                return first;
            }
            return second;
        }
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second)>0)
            {
                return first;
            }
            return second;
        }
    }
}
