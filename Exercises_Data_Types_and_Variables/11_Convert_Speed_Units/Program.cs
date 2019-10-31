using System;

namespace _11_Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float timeInSeconds = hours * 3600f + minutes * 60f + seconds;
            float metersPerSecond = meters * 1.0f / timeInSeconds;
            float kilPerHour = meters / timeInSeconds * 3.6f;
            float mielsPerHour = meters / timeInSeconds * 2.237414362784331f;
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilPerHour);
            Console.WriteLine(mielsPerHour);
        }
    }
}
