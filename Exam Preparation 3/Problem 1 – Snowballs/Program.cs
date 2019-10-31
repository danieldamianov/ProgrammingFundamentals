using System;
using System.Numerics;

namespace Problem_1___Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxSnowballSnow = 0;
            double maxSnowballTime = 0;
            double maxsnowballQuality = 0;
            BigInteger maxSnowballValue = 0;
            long numberSnowballs = long.Parse(Console.ReadLine());
            for (int i = 0; i < numberSnowballs; i++)
            {
                double snowballSnow = double.Parse(Console.ReadLine());
                double snowballTime = double.Parse(Console.ReadLine());
                double snowballQuality = double.Parse(Console.ReadLine());
                BigInteger snowballValue = 1;
                for (int j = 0; j < snowballQuality; j++)
                {
                    snowballValue *= (BigInteger)(snowballSnow / snowballTime);
                }
                if (snowballValue > maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxsnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxsnowballQuality})");
        }
    }
}
