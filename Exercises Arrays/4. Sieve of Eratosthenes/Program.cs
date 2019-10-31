using System;

namespace _4._Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;
            for (int p = 2; p < primes.Length; p++)
            {
                if(primes[p] == true)
                {
                    Console.Write(p + " ");
                    for (int i = 2; n >= i * p; i++)
                    {
                        primes[i * p] = false;
                    }
                }
            }
        }
    }
}
