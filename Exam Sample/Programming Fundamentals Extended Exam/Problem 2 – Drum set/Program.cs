using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Drum_set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> initial = new List<int>();
            foreach (var item in drumSet)
            {
                initial.Add(item);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Hit it again, Gabsy!")
                {
                    break;
                }
                int power = int.Parse(input);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= power;
                    if (drumSet[i] <=0)
                    {
                        if (initial[i] * 3 <= savings)
                        {
                            savings -= initial[i] * 3;
                            drumSet[i] = initial[i];
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            initial.RemoveAt(i);
                            i--;
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ",drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
