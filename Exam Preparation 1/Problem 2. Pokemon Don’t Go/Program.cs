using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                int currentIndex = int.Parse(Console.ReadLine());
                int operationElement = 0;
                if (currentIndex < 0)
                {
                    operationElement = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (currentIndex >= numbers.Count)
                {
                    operationElement = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    operationElement = numbers[currentIndex];
                    numbers.RemoveAt(currentIndex);
                }
                sum += operationElement;
                if (numbers.Count == 0)
                {
                    break;
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= operationElement)
                    {
                        numbers[i] += operationElement;
                    }
                    else
                    {
                        numbers[i] -= operationElement;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
