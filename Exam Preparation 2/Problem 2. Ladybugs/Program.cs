using System;
using System.Linq;

namespace Problem_2._Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCells = int.Parse(Console.ReadLine());
            bool[] field = new bool[numberOfCells];
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = false;
            }
            int[] indexesOfInitialLadyBugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (int pos in indexesOfInitialLadyBugs)
            {
                if(pos >= 0 && pos < field.Length)
                {
                    field[pos] = true;
                }
            }
            while (true)
            {
                string currentCommand = Console.ReadLine();
                if (currentCommand == "end")
                {
                    break;
                }
                string[] currentCommandArgs = currentCommand.Split(' ');
                int pos = int.Parse(currentCommandArgs[0]);
                string direction = currentCommandArgs[1];
                int dist = int.Parse(currentCommandArgs[2]);
                if ((pos < 0 || pos >= field.Length))
                {
                    continue;
                }
                if (field[pos] == false)
                {
                    continue;
                }
                field[pos] = false;
                int endPosition = pos;
                if(direction == "right")
                {
                    while (true)
                    {
                        endPosition += dist;
                        if (endPosition >= field.Length)
                        {
                            break;
                        }
                        if (field[endPosition] == false)
                        {
                            field[endPosition] = true;
                            break;
                        }
                    }
                }
                else
                {
                    while (true)
                    {
                        endPosition -= dist;
                        if (endPosition < 0)
                        {
                            break;
                        }
                        if (field[endPosition] == false)
                        {
                            field[endPosition] = true;
                            break;
                        }
                    }
                }
                
            }
            foreach (var cell in field)
            {
                if (cell)
                {
                    Console.Write(1 + " ");
                }
                else
                {
                    Console.Write(0 + " ");
                }
            }
        }
    }
}
