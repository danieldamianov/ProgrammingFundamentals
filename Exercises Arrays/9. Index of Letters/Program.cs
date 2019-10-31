using System;
using System.Linq;

namespace _9._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 'a' , j = 0; i <= 'z'; i++ , j++)
            {
                alphabet[j] = (char)i;
            }
            char[] input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                int number = 0;
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if(alphabet[j] == input[i])
                    {
                        number = j;
                        break;
                    }
                }
                Console.WriteLine($"{input[i]} -> {number}");
            }
        }
    }
}
