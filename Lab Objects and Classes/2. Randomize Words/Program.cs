using System;
using System.Globalization;

namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] words = Console.ReadLine().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                int position = rnd.Next(0, words.Length);
                string temp = words[i];
                words[i] = words[position];
                words[position] = temp;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
