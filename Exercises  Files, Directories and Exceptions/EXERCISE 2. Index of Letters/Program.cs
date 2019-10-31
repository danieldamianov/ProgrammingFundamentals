using System;
using System.IO;

namespace EXERCISE_2._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("output.txt","");
            string text = File.ReadAllText("input.txt");
            foreach (var letter in text)
            {
                File.AppendAllText("output.txt", $"{letter} -> {letter - 'a'}" + Environment.NewLine);
            }
        }
    }
}
