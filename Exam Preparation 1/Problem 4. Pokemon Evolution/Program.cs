using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Evolution>> pokemons = new Dictionary<string, List<Evolution>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "wubbalubbadubdub")
                {
                    break;
                }
                string[] inputArgs = input.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputArgs.Length == 1)
                {    
                    string nameOfPokemon = inputArgs[0];
                    if (pokemons.ContainsKey(nameOfPokemon) == false)
                    {
                        continue;
                    }
                    Console.WriteLine($"# {nameOfPokemon}");
                    foreach (var evolution in pokemons[nameOfPokemon])
                    {
                        Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                    }
                    continue;
                }
                string pokemonName = inputArgs[0];
                string pokemonType = inputArgs[1];
                int evolutionIndex = int.Parse(inputArgs[2]);
                if (pokemons.ContainsKey(pokemonName) == false)
                {
                    pokemons.Add(pokemonName, new List<Evolution>());
                }
                pokemons[pokemonName].Add(new Evolution(pokemonType, evolutionIndex));
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var evolution in pokemon.Value.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                }
            }
        }
    }
    class Evolution
    {
        public string Type { get; set; }
        public int Index { get; set; }
        public Evolution(string type , int index)
        {
            this.Type = type;
            this.Index = index;
        }
        public Evolution() { }
    }
}
