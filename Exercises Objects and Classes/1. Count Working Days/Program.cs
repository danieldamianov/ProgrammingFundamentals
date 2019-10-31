using System;
using System.Globalization;

namespace _1._Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = 0;
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            for (DateTime current = startDate; current <= endDate; current = current.AddDays(1))
            {
                if (((current.DayOfWeek == DayOfWeek.Saturday) ||
                    (current.DayOfWeek == DayOfWeek.Sunday) ||
                    (current.Month == 1 && current.Day == 1) ||
                    (current.Month == 3 && current.Day == 3) ||
                    (current.Month == 5 && current.Day == 1) ||
                    (current.Month == 5 && current.Day == 6) ||
                    (current.Month == 5 && current.Day == 24) ||
                    (current.Month == 9 && current.Day == 6) ||
                    (current.Month == 9 && current.Day == 22) ||
                    (current.Month == 11 && current.Day == 1) ||
                    (current.Month == 12 && current.Day == 24) ||
                    (current.Month == 12 && current.Day == 25) ||
                    (current.Month == 12 && current.Day == 26)
                    ) == false)
                {
                    holidays++;
                }
            }
            Console.WriteLine(holidays);
        }
    }
}
