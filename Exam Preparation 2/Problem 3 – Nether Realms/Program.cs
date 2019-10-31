using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double[]> demons = new SortedDictionary<string, double[]>();
            string[] demonsInput = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var demon in demonsInput)
            {
                double health = 0;
                double damage = 0;
                foreach (var sign in demon.Where(y => (
                y != '0' &&
                y != '1' &&
                y != '2' &&
                y != '3' &&
                y != '4' &&
                y != '5' &&
                y != '6' &&
                y != '7' &&
                y != '8' &&
                y != '9' &&
                y != '+' &&
                y != '-' &&
                y != '*' &&
                y != '/' &&
                y != '.' 
                )))
                {
                    health += sign;
                }
                MatchCollection numbers = Regex.Matches(demon, @"\d+(\.\d+)?");
                foreach (Match num in numbers)
                {
                    if (num.Index == 0)
                    {
                        damage += double.Parse(num.Value);
                    }
                    else if (demon[num.Index - 1] == '-')
                    {
                        damage -= double.Parse(num.Value);
                    }
                    else
                    {
                        damage += double.Parse(num.Value);
                    }
                }
                foreach (var sign in demon.Where(y => (
                y == '/' || y == '*'
                )))
                {
                    if (sign == '/')
                    {
                        damage /= 2;
                    }
                    else
                    {
                        damage *= 2;
                    }
                }
                demons.Add(demon, new double[] {health , damage});
            }
            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }
    }
}
