using System;
using System.IO;
using System.Text;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                sb.AppendLine((i + 1) + ". " + lines[i]);
            }
            File.WriteAllText("Output1.txt", sb.ToString());
        }
    }
}
