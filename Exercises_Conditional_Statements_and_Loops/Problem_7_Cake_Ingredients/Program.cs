using System;

namespace Problem_7_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            string ingredient = Console.ReadLine();
            Console.WriteLine($"Adding ingredient {ingredient}.");
            while (true)
            {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!") break;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
