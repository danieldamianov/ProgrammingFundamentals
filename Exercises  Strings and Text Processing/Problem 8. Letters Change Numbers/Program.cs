using System;
using System.Numerics;
using System.Linq;
namespace Problem_8._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' ,'\t'}, StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                /*if(word.Length <= 2 || (word.Any(x => x >= '0' && x <= '9') == false))
                {
                    continue;
                }*/
                double number = double.Parse(word.Substring(1, word.Length - 2));
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                if (firstLetter >= 'a' && firstLetter<='z')
                {
                    number *= (firstLetter - 'a' + 1);
                }
                if (firstLetter >= 'A' && firstLetter <= 'Z')
                {
                    number /= (firstLetter - 'A' + 1);
                }
                if (lastLetter >= 'a' && lastLetter <= 'z')
                {
                    number += (lastLetter - 'a' + 1);
                }
                if (lastLetter >= 'A' && lastLetter <= 'Z')
                {
                    number -= (lastLetter - 'A' + 1);
                }
                totalSum += number;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
