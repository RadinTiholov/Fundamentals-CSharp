using System;
using System.Linq;
using System.Collections.Generic;
namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            for (int i = 0; i < input.Count; i++)
            {
                List<string> result = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < result.Count; j++)
                {
                    Console.Write($"{result[j]} ");
                }
            }
        }
    }
}
