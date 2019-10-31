using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_2___Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                for (int i = 0; i < snowmen.Count; i++)
                {
                    if (snowmen[i] != -1)
                    {
                        int target = snowmen[i] % snowmen.Count;
                        if (Math.Abs(i - target) == 0)
                        {
                            Console.WriteLine($"{i} performed harakiri");
                            snowmen[i] = -1;
                        }
                        else if (Math.Abs(i - target) % 2 == 0)
                        {
                            Console.WriteLine($"{i} x {target} -> {i} wins");
                            snowmen[target] = -1;
                        }
                        else
                        {
                            Console.WriteLine($"{i} x {target} -> {target} wins");
                            snowmen[i] = -1;
                        }
                        if (snowmen.Count(x => x != -1) == 1)
                        {
                            return;
                        }

                    }
                }
                for (int i = 0; i < snowmen.Count; i++)
                {
                    if (snowmen[i] == -1)
                    {
                        snowmen.RemoveAt(i);
                        i--;
                    }
                }
                //snowmen.RemoveAll(x => x == -1);
            }
        }
    }
}
