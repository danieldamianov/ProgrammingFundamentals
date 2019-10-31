using System;
using System.Numerics;

namespace Problem_1._Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalLoses = 0m;
            int numberOfSites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            int numberOfAffectedSites = 0;
            for (int i = 0; i < numberOfSites; i++)
            {
                string[] currentSiteArgs = Console.ReadLine().Split(' ');
                string site = currentSiteArgs[0];
                decimal visits = decimal.Parse(currentSiteArgs[1]);
                decimal pricePerVisit = decimal.Parse(currentSiteArgs[2]);
                if (visits * pricePerVisit != 0)
                {
                    totalLoses += visits * pricePerVisit;
                    numberOfAffectedSites++;
                    Console.WriteLine(site);
                }
            }
            Console.WriteLine($"Total Loss: {totalLoses:f20}");
            
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey, numberOfAffectedSites)}");
        }
    }
}
