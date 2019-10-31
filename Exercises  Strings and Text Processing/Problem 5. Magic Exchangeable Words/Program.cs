using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            string word1 = words[0];
            string word2 = words[1];
            if(word1.Length == word2.Length)
            {
                if(AreExchangable(word1, word2))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                if (word1.Length > word2.Length)
                {
                    string temp = word1;
                    word1 = word2;
                    word2 = temp;
                }
                bool match = AreExchangable(word1, word2.Substring(0, word1.Count()));
                bool types = HaveTheSameNumberOfTypes(word1, word2);
                if (match && types)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }
        }
        static bool AreExchangable(string word1 , string word2)
        {
            foreach (var symbol in word1)
            {
                char firstSyymbolCorrespond = word2[word1.IndexOf(symbol)];
                foreach (var pos in positions(word1 , symbol))
                {
                    if(word2[pos] != firstSyymbolCorrespond)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static List<int> positions(string text, char searchedText)
        {
            List<int> positions = new List<int>();
            int index = 0;
            while (true)
            {
                index = text.IndexOf(searchedText, index);

                if (index == -1)
                {
                    break;
                }
                positions.Add(index);
                index++;
                
            }
            return positions;
        }
        static bool HaveTheSameNumberOfTypes(string word1 , string word2)
        {
            char[] word1Char = word1.ToCharArray();
            char[] word2Char = word2.ToCharArray();
            if(word1Char.Distinct().Count() == word2Char.Distinct().Count())
            {
                return true;
            }
            return false;
        }
    }
}
