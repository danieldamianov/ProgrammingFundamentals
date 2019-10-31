using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ,.?!".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            foreach (var word in words)
            {
                char[] wordCharArray = word.ToCharArray();
                if(string.Join("",wordCharArray) == string.Join("", wordCharArray.Reverse()))
                {
                    palindromes.Add(string.Join("", wordCharArray));
                }
            }
            Console.WriteLine(string.Join(", ",palindromes.Distinct().OrderBy(x => x)));
        }
    }
}
