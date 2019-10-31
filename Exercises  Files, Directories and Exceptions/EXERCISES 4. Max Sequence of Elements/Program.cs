using System;
using System.IO;
using System.Linq;

namespace EXERCISES_4._Max_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("output.txt", "");
            string[] lines = File.ReadAllLines("input.txt");
            foreach (var line in lines)
            {
                int[] numbers = line.Split(' ').Select(int.Parse).ToArray();
                int maxStart = 0;
                int maxLength = 0;
                int currentStart = 0;
                int currentLength = 1;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        currentLength++;
                    }
                    if (numbers[i] != numbers[i + 1] || i == numbers.Length - 2)
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            maxStart = currentStart;
                        }
                        currentStart = i + 1;
                        currentLength = 1;
                    }
                }
                File.AppendAllText("output.txt", $"{string.Join(" ", numbers.Skip(maxStart).Take(maxLength))}" + Environment.NewLine);
            }
        }
    }
}
