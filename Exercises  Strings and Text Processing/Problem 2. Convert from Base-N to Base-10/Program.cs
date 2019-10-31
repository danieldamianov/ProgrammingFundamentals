using System;
using System.Numerics;

namespace Problem_2._Convert_from_Base_N_to_Base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] argsN = Console.ReadLine().Split(' ');
            BigInteger baseN = BigInteger.Parse(argsN[0]);
            BigInteger number = BigInteger.Parse(argsN[1]);
            BigInteger numberIn10Base = 0;
            string numberString = number.ToString();
            BigInteger multiplier = 1;
            for (int i = numberString.Length - 1; i >= 0; i--)
            {
                numberIn10Base += multiplier * BigInteger.Parse(numberString[i].ToString());
                multiplier *= baseN;
            }
            Console.WriteLine(numberIn10Base);
        }
    }
}
