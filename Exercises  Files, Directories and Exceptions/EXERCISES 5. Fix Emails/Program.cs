using System;
using System.Collections.Generic;
using System.IO;

namespace EXERCISES_5._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("output.txt","");
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines("input.txt");
            for (int i = 1; i < lines.Length - 1; i+=2)
            {
                if (lines[i].EndsWith("us") || lines[i].EndsWith("uk"))
                {
                    continue;
                }
                dictionary.Add(lines[i - 1], lines[i]);
            }
            foreach (var kvp in dictionary)
            {
                File.AppendAllText("output.txt",kvp.Key  + " -> " + 
                    kvp.Value + Environment.NewLine);
            }
        }
    }
}
