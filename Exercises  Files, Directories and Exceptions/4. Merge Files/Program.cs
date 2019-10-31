using System;
using System.IO;
using System.Linq;

namespace _4._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines1 = File.ReadAllLines("FileOne.txt");
            string[] lines2 = File.ReadAllLines("FileTwo.txt");
            for (int i = 0; i < lines1.Length; i++)
            {
                File.AppendAllText("Output.txt", lines1[i] + Environment.NewLine);
                File.AppendAllText("Output.txt", lines2[i] + Environment.NewLine);
            }
        }
    }
}
