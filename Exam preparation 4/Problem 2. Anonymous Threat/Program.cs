using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_2._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput == "3:1")
                {
                    break;
                }
                string[] commandArgs = commandInput.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    // check again this !!!!!!!!
                    if ((startIndex < 0 && endIndex < 0)|| (startIndex >= text.Count && endIndex >= text.Count))
                    {
                        continue;
                    }
                    else if(startIndex < 0 && endIndex < text.Count)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex >= 0 && endIndex >= text.Count)
                    {
                        endIndex = text.Count - 1;
                    }
                    else if(startIndex < 0 && endIndex >= text.Count)
                    {
                        startIndex = 0;
                        endIndex = text.Count - 1;
                    }
                    
                    StringBuilder merged = new StringBuilder();
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        merged.Append(text[i]);
                    }
                    text.RemoveRange(startIndex, endIndex - startIndex + 1);
                    text.Insert(startIndex, merged.ToString());
                }
                else
                {
                    int index = int.Parse(commandArgs[1]);
                    int parts = int.Parse(commandArgs[2]);
                    if (text[index].Length % parts == 0)
                    {
                        int lengthOfPart = text[index].Length / parts;
                        List<string> partsList = new List<string>();
                        for (int i = 0; i < text[index].Length; i+=lengthOfPart)
                        {
                            partsList.Add(text[index].Substring(i, lengthOfPart));
                        }
                        text.RemoveAt(index);
                        text.InsertRange(index, partsList);
                    }
                    else
                    {
                        List<string> partsList = new List<string>();
                        int partsLength = text[index].Length / parts;
                        int lengthOfLastPart = text[index].Length - (parts - 1) * partsLength;
                        for (int i = 0; i < partsLength * (parts - 1); i+=partsLength)
                        {
                            partsList.Add(text[index].Substring(i, partsLength));
                        }
                        partsList.Add(text[index].Substring(partsLength * (parts - 1)));
                        text.RemoveAt(index);
                        text.InsertRange(index, partsList);
                    }
                }

            }
            Console.WriteLine(string.Join(" ",text));
        }
    }
}
