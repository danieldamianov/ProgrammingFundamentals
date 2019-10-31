using System;

namespace _2._Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string searchedText = Console.ReadLine().ToLower();
            int counter = 0;
            int index = 0;
            while (true)
            {
                index = text.IndexOf(searchedText, index);

                if (index == -1)
                {
                    break;
                }

                counter++;
                index++;
            }
            Console.WriteLine(counter);
        }
    }
}
