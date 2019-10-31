using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> listOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

                // 0  1  2 3 4 5 6  => 7
                // 25 31 6 9 2 4 7

                List<int> loserList = new List<int>();

                while (listOfNumbers.Count != 1)
                {
                    Console.WriteLine(string.Join(" ",listOfNumbers));
                    for (int index = 0; index < listOfNumbers.Count; index++)
                    {
                        if (Math.Abs(loserList.Count - listOfNumbers.Count) == 1)
                        {
                            continue;
                        }

                        if (loserList.Contains(index))
                        {
                            continue;
                        }

                        int attackerIndex = index;
                        int targteIndex = ValidIndex(listOfNumbers[attackerIndex], listOfNumbers.Count);
                        int absoluteValue = Math.Abs(attackerIndex - targteIndex);
                        Console.WriteLine($"Real Index : {targteIndex}");
                        if (absoluteValue == 0)
                        {
                            Console.WriteLine($"{attackerIndex} performed harakiri");
                            loserList.Add(attackerIndex);
                            loserList = loserList.Distinct().ToList();
                        }

                        if (absoluteValue != 0 && absoluteValue % 2 == 0)
                        {
                            Console.WriteLine($"{attackerIndex} x {targteIndex} -> {attackerIndex} wins");
                            loserList.Add(targteIndex);
                            loserList = loserList.Distinct().ToList();
                        }

                        if (absoluteValue % 2 == 1)
                        {
                            Console.WriteLine($"{attackerIndex} x {targteIndex} -> {targteIndex} wins");
                            loserList.Add(attackerIndex);
                            loserList = loserList.Distinct().ToList();
                        }
                    }

                    foreach (var index in loserList.OrderByDescending(x => x).Distinct())
                    {
                        listOfNumbers.RemoveAt(index);
                    }
                    Console.WriteLine(string.Join(" ", listOfNumbers));
                    loserList.Clear();
                }
            }
            catch
            {

            }
        }

        private static int ValidIndex(int index, int lenght)
        {
            if (index >= lenght)
            {
                index = index % lenght;
            }
            return index;
        }


    }
}