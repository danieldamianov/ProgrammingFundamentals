using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Problem_3._Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] values = Console.ReadLine().Split(new char[] { '}', '{' },StringSplitOptions.RemoveEmptyEntries);
            MatchCollection placeHolders = Regex.Matches(text, @"([A-Za-z]+)(?<placeholder>.+)(\1)");
            
            for (int i = 0; i < placeHolders.Count; i++)
            {
                if (i < values.Length)
                {
                    //text = ReplaceFirst(text, placeHolders[i].Groups["placeholder"].Value, values[i]);
                    int pos = text.IndexOf(placeHolders[i].Groups["placeholder"].Value);
                    text = text.Substring(0, pos) + values[i] + text.Substring(pos + placeHolders[i].Groups["placeholder"].Value.Length);
                }
            }
            Console.WriteLine(text);
        }
        static string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}
