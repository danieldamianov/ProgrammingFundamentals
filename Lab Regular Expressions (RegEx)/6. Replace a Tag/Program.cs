using System;
using System.Text.RegularExpressions;

namespace _6._Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string singleLine = Console.ReadLine();
            string patternOfA_Tag = @"<a.*?href=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";
            while(singleLine != "end")
            {
                string replaced = Regex.Replace(singleLine, patternOfA_Tag, replacement);
                Console.WriteLine(replaced);
                singleLine = Console.ReadLine();
            }
        }
    }
}
