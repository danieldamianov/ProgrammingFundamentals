using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problem_1___Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSum = 0;
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",CultureInfo.InvariantCulture);
                long capsuleCount = long.Parse(Console.ReadLine());
                decimal totalPrice = (DateTime.DaysInMonth(date.Year, date.Month) * capsuleCount) * pricePerCapsule;
                totalSum += totalPrice;
                Console.WriteLine($"The price for the coffee is: ${totalPrice:f2}");
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
