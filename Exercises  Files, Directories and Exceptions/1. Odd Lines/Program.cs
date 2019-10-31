using System;
using System.IO;
using System.Text;

namespace _1._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines("Input.txt");
            for (int i = 1; i < lines.Length; i+=2)
            {
                sb.AppendLine(lines[i]);
            }
            File.WriteAllText("Output.txt",sb.ToString());
        }
    }
}
