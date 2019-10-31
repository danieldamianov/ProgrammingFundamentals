using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            string[] commands = Console.ReadLine().Split(' ');
            while (commands[0] != "print")
            {
                if(commands[0] == "add")
                {
                    input.Insert(int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if(commands[0] == "addMany")
                {
                    List<int> range = new List<int>();
                    for (int i = 2; i < commands.Length; i++)
                    {
                        range.Add(int.Parse(commands[i]));
                    }
                    input.InsertRange(int.Parse(commands[1]), range);
                }
                else if(commands[0] == "contains")
                {
                    if (input.Contains(int.Parse(commands[1])))
                    {
                        Console.WriteLine(input.FindIndex(s => s == int.Parse(commands[1])));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if(commands[0] == "remove")
                {
                    input.RemoveAt(int.Parse(commands[1]));
                }
                else if(commands[0] == "shift")
                {
                    int position = int.Parse(commands[1]) % input.Count;
                    List<int> helper = input.Skip(position).ToList();
                    for (int i = 0; i < position; i++)
                    {
                        helper.Add(input[i]);
                    }
                    input = helper;
                    /*for (int i = 0; i < int.Parse(commands[1]); i++)
                    {
                        int first = input[0];
                        input.RemoveAt(0);
                        input.Add(first);
                    }*/
                }
                else if(commands[0] == "sumPairs")
                {
                    int cycles = input.Count / 2;
                    for (int i = 0; i < cycles; i++)
                    {
                        input[i] += input[i + 1];
                        input.RemoveAt(i + 1);
                    }
                    /*List<int> temp = new List<int>();
                    for (int i = 0; i < input.Count; i+=2)
                    {
                        int sum = 0;
                        if (i != input.Count - 1)
                        {
                            sum = input[i] + input[i + 1];
                        }
                        else sum = input[i];
                        temp.Add(sum);
                    }
                    input = temp;*/
                }
                commands = Console.ReadLine().Split(' ');
            }
            Console.WriteLine("[" + string.Join(", ",input)+"]");
        }
    }
}
