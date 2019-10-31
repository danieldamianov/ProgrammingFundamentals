using System;
using System.Collections.Generic;
using System.Linq;
namespace _4._Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] {',' , ';' , ':' ,'.' ,'!','(',')','\"','\'','\\','/','[',']',' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            foreach (var word in input)
            {
                switch (GetTypeOfWord(word))
                {
                    case 1:
                        lowerCase.Add(word);
                            break;
                    case 2:
                        mixedCase.Add(word);
                        break;
                    case 3:
                        upperCase.Add(word);
                        break;
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ",mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ",upperCase));
        }
        static int GetTypeOfWord(string word)
        {
            bool lowerCase = false;
            bool upperCase = false;
            bool otherDigit = false;
            foreach (var letter in word)
            {
                if(letter <= 'z' && letter >= 'a')
                {
                    lowerCase = true;
                }else
                if (letter <= 'Z' && letter >= 'A')
                {
                    upperCase = true;
                }
                else
                {
                    otherDigit = true;
                }
            }
            if(upperCase == true && lowerCase == false && otherDigit == false)
            {
                return 3;
            }
            if (upperCase == false && lowerCase == true && otherDigit == false)
            {
                return 1;
            }
            return 2;
        }
    }
}
