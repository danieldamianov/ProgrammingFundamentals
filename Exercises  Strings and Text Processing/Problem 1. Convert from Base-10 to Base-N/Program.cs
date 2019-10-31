using System;
using System.Collections.Generic;
using System.Numerics;

namespace Problem_1._Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] argsN = Console.ReadLine().Split(' ');
            BigInteger baseN = BigInteger.Parse(argsN[0]);
            BigInteger number = BigInteger.Parse(argsN[1]);
            List<BigInteger> readyNumber = new List<BigInteger>();
            while (true)
            {
                readyNumber.Insert(0, number % baseN);
                number = number / baseN;
                if(number < baseN)
                {
                    if(number != 0)
                    readyNumber.Insert(0, number);
                    break;
                }
            }
            Console.WriteLine(string.Join("",readyNumber));
        }
    }
}
