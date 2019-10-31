using System;

namespace Problem_4._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            string word1 = words[0];
            string word2 = words[1];
            Console.WriteLine(SumOfWords(word1 , word2));
        }
        static int SumOfWords(string word1 , string word2)
        {
            int sum = 0;
            if(word1.Length > word2.Length)
            {
                string temp = word1;
                word1 = word2;
                word2 = temp;
            }
            int dif = word2.Length - word1.Length;
            for (int i = 0; i < word1.Length; i++)
            {
                sum += (int)word1[i] * (int)word2[i];
            }
            for (int i = 0; i < dif; i++)
            {
                sum += (int)word2[word1.Length + i];
            }
            return sum;
        }
    }
}
