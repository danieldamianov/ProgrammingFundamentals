using System;

namespace Problem_15__Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());
            int GoshoHealth = 100;
            int PeshoHealth = 100;
            bool turn = true;// true = Pesho , false = Gosho
            int counterOfTurns = 0;
            while(GoshoHealth > 0 && PeshoHealth > 0)
            {
                counterOfTurns++;
                if (turn)
                {
                    GoshoHealth -= PeshoDamage;
                    if(GoshoHealth>0) Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                }
                else
                {
                    PeshoHealth -= GoshoDamage;
                    if(PeshoHealth>0) Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                }
                if(counterOfTurns%3==0 && GoshoHealth>0 && PeshoHealth>0)
                {
                    GoshoHealth += 10;
                    PeshoHealth += 10; 
                }
                turn = !turn;
            }
            if(GoshoHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {counterOfTurns}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {counterOfTurns}th round.");
            }
        }
    }
}
