using System;

namespace Problem_12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int bounder = int.Parse(Console.ReadLine());
            int sum = 0, counter = 0;
            for (int i = first; i >= 1; i--) 
            {
                for (int j = 1; j <= second; j++)
                {
                    counter++;
                    sum += 3 * (i*j);
                    if (sum >= bounder)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {bounder}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
