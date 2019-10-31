using System;
using System.Linq;

namespace _6._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areFif = true;
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int longestSeqStartInd = 0;
            int longestSeqEndInd = 0;
            int longestSeqLength = 0;
            int currentSeqLength = 1;
            int currentSeqStart = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] < input[i + 1])
                {
                    currentSeqLength++;
                }
                if (input[i] >= input[i + 1] || i == input.Length - 2)
                {
                    areFif = false;
                    if (currentSeqLength > longestSeqLength)
                    {
                        longestSeqLength = currentSeqLength;
                        longestSeqStartInd = currentSeqStart;
                        if (i == input.Length - 2 && input[i] < input[i + 1])
                            longestSeqEndInd = i + 1;
                        else
                            longestSeqEndInd = i;
                        currentSeqStart = i + 1;
                        currentSeqLength = 1;
                    }
                    else
                    {
                        currentSeqStart = i + 1;
                        currentSeqLength = 1;
                    }
                }
            }
            if (!areFif)
                for (int i = longestSeqStartInd; i <= longestSeqEndInd; i++)
                {
                    Console.Write(input[i] + " ");
                }
            else
            {
                Console.WriteLine(string.Join(" ", input));
            }
        }
    }
}
