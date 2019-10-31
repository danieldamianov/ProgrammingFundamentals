using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.__Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            //int overflow ???
            var container = new Dictionary< string , SortedDictionary<string , int[]> >();
            int numberOfDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] currentDragon = Console.ReadLine().Split(' ').ToArray();//unnecessary
                string type = currentDragon[0];
                string name = currentDragon[1];
                int damage = 45;
                int health = 250;
                int armor = 10;
                if (currentDragon[2] != "null")
                damage = int.Parse(currentDragon[2]);
                if (currentDragon[3] != "null")
                health = int.Parse(currentDragon[3]);
                if (currentDragon[4] != "null")
                armor = int.Parse(currentDragon[4]);
                if(container.ContainsKey(type) == false)
                {
                    container.Add(type, new SortedDictionary<string, int[]>());
                }
                if(container[type].ContainsKey(name) == false)
                {
                    container[type].Add(name, new int[3]);
                }
                container[type][name][0] = damage;
                container[type][name][1] = health;
                container[type][name][2] = armor;
                
            }
            foreach (var typeDragon in container)
            {
                double sumDamage = 0;
                double sumHealth = 0;
                double sumArmour = 0;
                foreach (var properties in typeDragon.Value.Values)
                {
                    sumDamage += properties[0];
                    sumHealth += properties[1];
                    sumArmour += properties[2];
                }
                sumDamage /= typeDragon.Value.Count; 
                sumHealth /= typeDragon.Value.Count;
                sumArmour /= typeDragon.Value.Count;
                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", typeDragon.Key, sumDamage, sumHealth, sumArmour);
                foreach (var dragon in typeDragon.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
