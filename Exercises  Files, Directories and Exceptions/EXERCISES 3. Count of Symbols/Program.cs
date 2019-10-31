using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EXERCISES_3._Count_of_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("input.txt");
            Dictionary<char, int> occurances = new Dictionary<char, int>();
            foreach (var symbol in text.Where(x => x != ' '))
            {
                if (!occurances.ContainsKey(symbol))
                {
                    occurances.Add(symbol, 0);
                }
                occurances[symbol]++;
            }
            File.WriteAllText("output.txt","");
            foreach (var occurance in occurances.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("output.txt", $"{occurance.Key} -> {occurance.Value}" + Environment.NewLine);
            }
        }
    }
}
