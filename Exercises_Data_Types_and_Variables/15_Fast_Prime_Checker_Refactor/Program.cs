using System;

namespace _15_Fast_Prime_Checker_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());    
            for(int numberToCheck = 2;numberToCheck <=n; numberToCheck++)
            {
                bool isPrime = true;
                for (int div = 2; div <= Math.Sqrt(numberToCheck); div++)
                {
                    if(numberToCheck % div == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{numberToCheck} -> {isPrime}");
            }
        }
    }
}
