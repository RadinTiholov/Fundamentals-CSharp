using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            while (true)
            {
                if (first[0] > second[0])
                {
                    first.Add(first[0]);
                    first.Add(second[0]);
                }
                else if(first[0] < second[0])
                {

                    second.Add(second[0]);
                    second.Add(first[0]);
                }

                first.Remove(first[0]);
                second.Remove(second[0]);
                if (first.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
                    break;
                }
                else if (second.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {first.Sum()}");
                    break;
                }
            }
        }
    }
}
