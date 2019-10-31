using System;

namespace Problem_1._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            long counter = 0;
            long totalPower = long.Parse(Console.ReadLine());
            long distance = long.Parse(Console.ReadLine());
            long exhaustionFactor = long.Parse(Console.ReadLine());
            long initalPower = totalPower;
            while (totalPower >= distance)
            {
                totalPower -= distance;
                counter++;
                if(totalPower == initalPower / 2)
                {
                    if((exhaustionFactor != 0) && totalPower / exhaustionFactor != 0)
                    {
                        totalPower /= exhaustionFactor;
                    }
                }
            }
            Console.WriteLine(totalPower);
            Console.WriteLine(counter);
        }
    }
}
