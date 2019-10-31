using System;

namespace Problem_4_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            switch (month)
            {
                case "May":
                    if (nights > 7) Console.WriteLine("Studio: {0:f2} lv.", nights * 50 * 95 / 100);
                    else Console.WriteLine("Studio: {0:f2} lv.",nights * 50);
                    Console.WriteLine("Double: {0:f2} lv.",nights * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
                    break;
                case "October":
                    if (nights > 7) Console.WriteLine("Studio: {0:f2} lv.", (nights-1) * 50 * 95 / 100);
                    else Console.WriteLine("Studio: {0:f2} lv.", nights * 50);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 65);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 75);
                    break;
                case "June":
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 60);
                    if (nights > 14) Console.WriteLine("Double: {0:f2} lv.", nights * 72 * 90 / 100);
                    else Console.WriteLine("Double: {0:f2} lv.", nights * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                    break;
                case "September":
                    if (nights > 7) Console.WriteLine("Studio: {0:f2} lv.", (nights-1) * 60);
                    else Console.WriteLine("Studio: {0:f2} lv.", (nights - 1) * 60);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 72);
                    Console.WriteLine("Suite: {0:f2} lv.", nights * 82);
                    break;
                case "July":
                case "August":
                case "December":
                    Console.WriteLine("Studio: {0:f2} lv.", nights * 68);
                    Console.WriteLine("Double: {0:f2} lv.", nights * 77);
                    if (nights > 14) Console.WriteLine("Suite: {0:f2} lv.", nights * 89 * 85 / 100);
                    else Console.WriteLine("Suite: {0:f2} lv.", nights * 89);
                    break;
            }
        }
    }
}
