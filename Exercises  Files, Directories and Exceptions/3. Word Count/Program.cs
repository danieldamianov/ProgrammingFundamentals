using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            string text = File.ReadAllText("text.txt").ToLower();
            string[] words = File.ReadAllText("words.txt").ToLower().Split(' ');
            foreach (var word in words)
            {
                string pattern = $@"\b{word}\b";
                MatchCollection matchedWords = Regex.Matches(text, pattern);
                wordsCount[word] = matchedWords.Count;
            }
            foreach (var word in wordsCount.OrderByDescending(x => x.Value))
            {
                sb.AppendLine($"{word.Key} - {word.Value}");
            }
            File.WriteAllText("Output.txt", sb.ToString());
        }
    }
}
