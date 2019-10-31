using System;
using System.Linq;

namespace Problem_2._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            int sequenceLength = int.Parse(Console.ReadLine());
            int maxSequenceLength = -1;
            int maxSequenceSum = 0;
            int maxSequenceIndex = 0;
            string maxSequence = "";
            int maxIndex = 0;
            int index = 0;
            while (true)
            {
                index++;
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    if (index == 1)
                    {
                        return;
                    }
                    break;
                }
                int[] currnetSequence = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int startIndex = 0;
                int maxStartIndex = 0;
                int subSeqLength = 0;
                int maxSubSeqLength = 0;
                for (int i = 0; i < sequenceLength; i++)
                {
                    if (currnetSequence[i] == 1)
                    {
                        if (subSeqLength == 0)
                        {
                            startIndex = i;
                        }
                        subSeqLength++;
                    }
                    if(i == (sequenceLength - 1) || (currnetSequence[i] != 1))
                    {
                        if (subSeqLength > maxSubSeqLength)
                        {
                            maxSubSeqLength = subSeqLength;
                            maxStartIndex = startIndex;
                        }
                        subSeqLength = 0;
                    }
                }
                if (maxSubSeqLength > maxSequenceLength)
                {
                    maxSequence = string.Join(" ", currnetSequence);
                    maxSequenceLength = maxSubSeqLength;
                    maxSequenceSum = currnetSequence.Sum();
                    maxSequenceIndex = maxStartIndex;
                    maxIndex = index;
                }
                else if(maxSubSeqLength == maxSequenceLength && maxSequenceIndex > maxStartIndex)
                {
                    maxSequence = string.Join(" ", currnetSequence);
                    maxSequenceLength = maxSubSeqLength;
                    maxSequenceSum = currnetSequence.Sum();
                    maxSequenceIndex = maxStartIndex;
                    maxIndex = index;
                }
                else if(maxSubSeqLength == maxSequenceLength && maxSequenceIndex == maxStartIndex && currnetSequence.Sum() > maxSequenceSum)
                {
                    maxSequence = string.Join(" ", currnetSequence);
                    maxSequenceLength = maxSubSeqLength;
                    maxSequenceSum = currnetSequence.Sum();
                    maxSequenceIndex = maxStartIndex;
                    maxIndex = index;
                }
                
                
            }
            Console.WriteLine($"Best DNA sample {maxIndex} with sum: {maxSequenceSum}.");
            Console.WriteLine(maxSequence);
        }
    }
}
