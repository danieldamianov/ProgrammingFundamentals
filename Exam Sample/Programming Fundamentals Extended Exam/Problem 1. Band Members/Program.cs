using System;

namespace Problem_1._Band_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            int members = int.Parse(Console.ReadLine());
            int guitarists = members / 3;
            int drummers = members - guitarists - 1;
            double guitarPrice = double.Parse(Console.ReadLine());
            double drumPrice = guitarPrice * 3 / 2;
            double microPhonePrice = Math.Abs(guitarPrice * guitarists - drumPrice * drummers);
            double rent = 12 * (guitarists * guitarPrice + microPhonePrice + drummers * drumPrice) / members;
            Console.WriteLine($"Total cost: {guitarists * guitarPrice + microPhonePrice + drummers * drumPrice + rent:f2}lv.");
        }
    }
}
