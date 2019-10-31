using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _6.__Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MatchCollection unamesColl = Regex.Matches(text, @"(^|(?<=[\s\/()]))(?<name>[A-Za-z][A-Za-z_0-9]{2,24})($|(?=[\s\/()]))");
            List<string> usernames = new List<string>();
            foreach (Match uname in unamesColl)
            {
                usernames.Add(uname.Groups["name"].Value);
            }
            string firstOfTheUserNames = "";
            string secondOfTheUserNames = "";
            int sumOfDigits = 0;
            for (int i = 0; i < usernames.Count - 1; i++)
            {
                    if ((usernames[i].Length + usernames[i + 1].Length) > sumOfDigits)
                    {
                        firstOfTheUserNames = usernames[i];
                        secondOfTheUserNames = usernames[i + 1];
                        sumOfDigits = usernames[i].Length + usernames[i + 1].Length;
                    }
            }
            Console.WriteLine(string.Join(" ",usernames));
            Console.WriteLine(firstOfTheUserNames);
            Console.WriteLine(secondOfTheUserNames);
        }
    }
}
