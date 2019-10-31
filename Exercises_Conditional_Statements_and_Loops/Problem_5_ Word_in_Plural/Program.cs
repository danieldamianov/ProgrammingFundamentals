using System;

namespace Problem_5__Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.EndsWith("s")|| input.EndsWith("o")|| input.EndsWith("ch")
               || input.EndsWith("x")|| input.EndsWith("z")|| input.EndsWith("sh"))
            {
                Console.WriteLine(input + "es");
            }
            else if (input.EndsWith("y"))
            {
                int position = input.Length - 1;
                Console.WriteLine(input.Remove(position)+"ies");
            }
            else
            {
                Console.WriteLine(input + "s");
            }
        }
    }
}
