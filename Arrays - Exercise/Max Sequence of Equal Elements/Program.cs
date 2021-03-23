using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

            int bestSeqSize = 0;
            int bestSeqNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                int sequenceSize = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNumber = arr[j];
                    if (currentNumber == rightNumber)
                    {
                        sequenceSize++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequenceSize > bestSeqSize)
                {
                    bestSeqSize = sequenceSize;
                    bestSeqNumber = currentNumber;
                }
            }
            for (int i = 0; i < bestSeqSize + 1; i++)
            {
                Console.Write(bestSeqNumber + " ");
            }
        }
    }
}
