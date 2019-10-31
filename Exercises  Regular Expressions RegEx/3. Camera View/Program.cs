using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _3._Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int elementsToSkip = input[0];
            int elementsToTake = input[1];
            string text = Console.ReadLine();
            
            MatchCollection names = Regex.Matches(text, ("\\|<\\w{0," + elementsToSkip + "}(?<take>\\w{0," + elementsToTake + "})"));
            List<string> namesList = new List<string>();
            foreach (Match name in names)
            {
                namesList.Add(name.Groups["take"].Value);
            }
            Console.WriteLine(string.Join(", ",namesList));
        }
    }
}
