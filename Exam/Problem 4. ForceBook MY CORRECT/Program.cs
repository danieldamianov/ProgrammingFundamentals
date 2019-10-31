using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_4._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forces = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                if (input.Contains(" | "))
                {
                    string[] inputArgs = Regex.Split(input, @"\s\|\s").Select(x => x.Trim()).ToArray();
                    string forceSide = inputArgs[0];
                    string forceUser = inputArgs[1];
                    if (forces.ContainsKey(forceSide) == false)
                    {
                        forces.Add(forceSide, new List<string>());
                    }
                    bool ok = true;
                    foreach (var force in forces)
                    {
                        if (force.Value.Contains(forceUser))
                        {
                            ok = false;
                        }
                    }
                    if (ok == false)
                    {
                        continue;
                    }
                    forces[forceSide].Add(forceUser);
                    forces[forceSide] = forces[forceSide].Distinct().ToList();
                }
                else if (input.Contains(" -> "))
                {
                    string[] inputArgs = Regex.Split(input, @"\s\-\>\s")
                        .Select(c => c.Trim()).ToArray();
                    string forceSide = inputArgs[1];
                    string forceUser = inputArgs[0];
                    if (forces.ContainsKey(forceSide))
                    {
                        if (forces[forceSide].Contains(forceUser))
                        {
                            continue;
                        }
                    }
                    foreach (var force in forces)
                    {
                        if (force.Value.Contains(forceUser))
                        {
                            force.Value.Remove(forceUser);
                            break;
                        }
                    }
                    if (forces.ContainsKey(forceSide) == false)
                    {
                        forces.Add(forceSide, new List<string>());
                    }
                    forces[forceSide].Add(forceUser);
                    forces[forceSide] = forces[forceSide].Distinct().ToList();
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }
            foreach (var force in forces.Where(x => x.Value.Distinct().Any()).Distinct()
                .OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {force.Key}, Members: {force.Value.Distinct().Count()}");
                foreach (var user in force.Value.Distinct().OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
