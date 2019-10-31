using System;

namespace Problem_1._Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthInDays = int.Parse(Console.ReadLine());
            int numberOfRunners = int.Parse(Console.ReadLine());
            int lapsPerRunner = int.Parse(Console.ReadLine());
            double lengthOfTrack = double.Parse(Console.ReadLine()) / 1000;
            int capacityOfTrack = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());
            int numberOfRunningRuners = lengthInDays * capacityOfTrack;
            if (numberOfRunners < numberOfRunningRuners)
            {
                numberOfRunningRuners = numberOfRunners;
            }
            double totalKilometres = numberOfRunningRuners * lapsPerRunner * lengthOfTrack;
            double totalSum = totalKilometres * moneyPerKilometer;
            Console.WriteLine($"Money raised: {totalSum:f2}");
        }
    }
}
