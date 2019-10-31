using System;
using System.Linq;

namespace _8._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int mostlyApperaedNumber = 0;
            int mostlyApperancesOfNumber = 0;
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                int currentApps = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if(input[i] == input[j])
                    {
                        currentApps++;
                    }
                }
                if(mostlyApperancesOfNumber < currentApps)
                {
                        mostlyApperaedNumber = input[i];
                        mostlyApperancesOfNumber = currentApps;
                }
            }
            Console.WriteLine($"{mostlyApperaedNumber}");
        }
    }
}
