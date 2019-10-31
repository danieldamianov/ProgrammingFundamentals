using System;

namespace Problem_13_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int firstComb = 0;
            int counter = 0;
            int secondComb = 0;
            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    if (i + j == magic)
                    {
                        firstComb = i;
                        secondComb = j;

                    }
                    counter++;
                }
            }
            if (firstComb != 0 && secondComb != 0)
            {
                Console.WriteLine($"Number found! {firstComb} + {secondComb} = {magic}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}
