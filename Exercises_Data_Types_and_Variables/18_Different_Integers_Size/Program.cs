using System;

namespace _18_Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string message = "";
            bool canFit = false;
            try
            {
                sbyte num = sbyte.Parse(number);
                message += "* sbyte\n";
                canFit = true;
            }
            catch (Exception) { }
            try
            {
                byte num = byte.Parse(number);
                message += "* byte\n";
                canFit = true;
            }
            catch (Exception) {  }
            try
            {
                short num = short.Parse(number);
                message += "* short\n";
                canFit = true;
            }
            catch (Exception) {  }
            try
            {
                ushort num = ushort.Parse(number);
                message += "* ushort\n";
                canFit = true;
            }
            catch (Exception) {  }
            try
            {
                int num = int.Parse(number);
                message += "* int\n";
                canFit = true;
            }
            catch (Exception) {  }
            try
            {
                uint num = uint.Parse(number);
                message += "* uint\n";
                canFit = true;
            }
            catch (Exception) {  }
            try
            {
                long num = long.Parse(number);
                message += "* long\n";
                canFit = true;
            }
            catch (Exception) { }
            if (canFit)
            {
                Console.WriteLine($"{number} can fit in:");
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
