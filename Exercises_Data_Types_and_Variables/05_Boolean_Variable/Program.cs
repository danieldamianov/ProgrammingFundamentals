using System;

namespace _05_Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool type = Convert.ToBoolean(text);
            if (type)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
