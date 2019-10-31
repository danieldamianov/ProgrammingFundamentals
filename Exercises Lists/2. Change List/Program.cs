using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            string command = "";
            do
            {
                string[] commandParameters = Console.ReadLine().Split(' ');
                command = commandParameters[0];
                if (command == "Delete")
                input.RemoveAll(s => s == int.Parse(commandParameters[1]));
                else if(command == "Insert")
                {
                    input.Insert(int.Parse(commandParameters[2]), int.Parse(commandParameters[1]));
                }
            }
            while (command != "Odd" && command != "Even");
            if(command == "Odd")
            {
                foreach (var num in input)
                {
                    if(num % 2 == 1)
                    {
                        Console.Write(num + " ");
                    }
                }
            } else
            if (command == "Even")
            {
                foreach (var num in input)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }

        }
    }
}
