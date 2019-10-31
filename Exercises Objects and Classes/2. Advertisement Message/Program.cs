using System;

namespace _2._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMesseages = int.Parse(Console.ReadLine());
            string[] basePhrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] baseEvents = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] baseAuthors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] baseCities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            for (int i = 0; i < numMesseages; i++)
            {
                Random rnd = new Random();
                int posPhrases = rnd.Next(0, basePhrases.Length);
                int posEvents = rnd.Next(0, baseEvents.Length);
                int posAuthors = rnd.Next(0, baseAuthors.Length);
                int posCitirs = rnd.Next(0, baseCities.Length);
                Console.WriteLine($"{basePhrases[posPhrases]} {baseEvents[posEvents]} {baseAuthors[posAuthors]} – {baseCities[posCitirs]}.");
            }
            
        }
    }
}
