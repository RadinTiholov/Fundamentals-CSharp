using System.Linq;
using System;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            int result = 0;
            bool isExisting = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                if (i == 0)
                {
                    leftSum = 0;
                }
                else
                {
                    for (int j = i; j > 0; j--)
                    {
                        leftSum += arr[j-1];
                    }
                }
                for (int k = i; k < arr.Length-1; k++)
                {
                    rightSum += arr[k + 1];
                }
                if (rightSum == leftSum)
                {
                    result = i;
                    isExisting = true;
                }
            }
            if (isExisting)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
