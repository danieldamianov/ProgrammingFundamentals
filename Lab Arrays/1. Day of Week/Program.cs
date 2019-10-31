using System;

namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = {"Monday" , "Tuesday" , "Wednesday" , "Thursday"
            , "Friday" , "Saturday" , "Sunday"};
            int day = int.Parse(Console.ReadLine());
            if(day > 7 || day < 1)
            {
                Console.WriteLine("Invalid day!");
            }
            else Console.WriteLine(week[day  - 1]);
        }
    }
}
