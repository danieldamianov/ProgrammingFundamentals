using System;

namespace Problem_9._Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();
            while (true)
            {
                int firstPos = text.IndexOf(pattern);
                int lastPos = text.LastIndexOf(pattern);
                
                if (firstPos == lastPos || firstPos == -1)
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                text = text.Remove(firstPos, pattern.Length);
                text = text.Remove(text.LastIndexOf(pattern), pattern.Length);
                Console.WriteLine("Shaked it.");
                pattern = pattern.Remove(pattern.Length / 2, 1);
                if(pattern == string.Empty)
                {
                    Console.WriteLine("No shake.");
                    break;
                }
            }
            Console.WriteLine(text);
        }
    }
}
