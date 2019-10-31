using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] commandArgs = input.Split(' ');
                if (commandArgs[0] == "reverse")
                {
                    int start = int.Parse(commandArgs[2]);
                    int count = int.Parse(commandArgs[4]);
                    if (start < 0 || start >= list.Count || count < 0 || (start + count) > list.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    list.Reverse(start, count);
                }
                else if (commandArgs[0] == "sort")
                {
                    int start = int.Parse(commandArgs[2]);
                    int count = int.Parse(commandArgs[4]);
                    if (start < 0 || start >= list.Count || count < 0 || (start + count) > list.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    list.Sort(start, count, Comparer<string>.Default);
                }
                else if (commandArgs[0] == "rollLeft")
                {
                    if (int.Parse(commandArgs[1]) < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    int number = int.Parse(commandArgs[1]) % list.Count;
                    for (int i = 0; i < number; i++)
                    {
                        string firstElem = list[0];
                        list.RemoveAt(0);
                        list.Add(firstElem);
                    }
                }
                else if (commandArgs[0] == "rollRight")
                {
                    if (int.Parse(commandArgs[1]) < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    int number = int.Parse(commandArgs[1]) % list.Count;
                    for (int i = 0; i < number; i++)
                    {
                        string lastElem = list.Last();
                        list.RemoveAt(list.Count - 1);
                        list.Insert(0,lastElem);
                    }
                }
                //Console.WriteLine($"[{string.Join(", ", list)}]");
            }
            Console.WriteLine($"[{string.Join(", ",list)}]");
        }
    }
}
