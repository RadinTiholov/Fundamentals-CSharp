using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int a = input[0];
                int b = input[1];
                if (i % 2 == 0)
                {
                    firstArr[i] = a;
                    secondArr[i] = b;
                }
                else if (i % 2 == 1)
                {
                    firstArr[i] = b;
                    secondArr[i] = a;
                }
            }
            Console.WriteLine(string.Join(" ",  firstArr));
            Console.WriteLine(string.Join(" ",  secondArr));
        }
    }
}
