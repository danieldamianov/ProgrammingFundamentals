using System;
using System.Numerics;

namespace _1_Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minuters = hours * 60;
            ulong seconds = (ulong)minuters * 60;
            ulong milliseconds = seconds * 1000;
            var microseconds = new BigInteger (milliseconds * 1000);
            var nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minuters} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
