using System;
using System.Linq;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1S = Console.ReadLine().TrimStart('0');
            string number2S = Console.ReadLine().TrimStart('0');
            if (number1S.Length < number2S.Length)
            {
                string temp = number1S;
                number1S = number2S;
                number2S = temp;
            }
            int dif = number1S.Length - number2S.Length;
            number2S = number2S.Insert(0, new string('0', dif));
            int[] number1 = number1S.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            int[] number2 = number2S.ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            int[] result = new int[number1.Length];
            int naum = 0;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                int current = number1[i] + number2[i] + naum;
                result[i] = current % 10;
                if (current >= 10)
                {
                    naum = 1;
                }
                else
                {
                    naum = 0;
                }
            }
            if (naum == 1)
            {
                Console.Write(1);
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
