using System;
using System.Linq;

namespace Problem_7._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInput = Console.ReadLine();
            string multiplierInput = Console.ReadLine();
            if (numberInput == "0" || multiplierInput == "0")
            {
                Console.WriteLine(0);
                return;
            }
            int[] number = numberInput
                .TrimStart('0')
                .ToCharArray()
                .Select(x => (int)Char.GetNumericValue(x))
                .ToArray();
            int multiplier = int.Parse(multiplierInput.TrimStart('0'));
            int naum = 0;
            int[] result = new int[number.Length];
            for (int i = result.Length - 1; i >= 0; i--)
            {
                int currentMultiplication = number[i] * multiplier + naum;
                result[i] = currentMultiplication % 10;
                naum = currentMultiplication / 10;
            }
            if (naum != 0)
            {
                Console.Write(naum);
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}
