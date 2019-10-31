using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EXERCISE_1._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("output.txt", "");
            string[] lines = File.ReadAllLines("input.txt");
            foreach (var numbers in lines)
            {
                Dictionary<int, int> occurances = new Dictionary<int, int>();
                foreach (var num in numbers.Split(' ').Select(int.Parse))
                {
                    if (occurances.ContainsKey(num) == false)
                    {
                        occurances.Add(num, 0);
                    }
                    occurances[num]++;
                }
                int maxNumber = 0;
                int maxOccur = 0;
                foreach (var occur in occurances)
                {
                    if (occur.Value > maxOccur)
                    {
                        maxOccur = occur.Value;
                        maxNumber = occur.Key;
                    }
                }
                File.AppendAllText("output.txt", maxNumber.ToString() + Environment.NewLine);
            }
        }
    }
}
