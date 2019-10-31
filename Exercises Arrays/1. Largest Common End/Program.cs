using System;

namespace _1._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');
            int counterOfTheBegin = 0;
            int counterOfTheEnd = 0;
            for (int i = 0; i < Math.Min(firstArr.Length,secondArr.Length); i++)
            {
                if(firstArr[i] == secondArr[i])
                {
                    counterOfTheBegin++;
                }
                else
                {
                    break;
                }
            }
            for (int i = firstArr.Length - 1 , j = secondArr.Length - 1; i >= 0 && j >=0; i-- , j--)
            {
                if (firstArr[i] == secondArr[j])
                {
                    counterOfTheEnd++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(Math.Max(counterOfTheBegin , counterOfTheEnd));
        }
    }
}
