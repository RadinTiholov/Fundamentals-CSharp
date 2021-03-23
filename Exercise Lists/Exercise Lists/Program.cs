using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "end")
            {
                var splitted = input.Split(" ");
                if (input.Contains("Add"))
                {
                    string command = splitted[0];
                    int n = int.Parse(splitted[1]);
                    list.Add(n);
                }
                else
                {
                    int n = int.Parse(splitted[0]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + n <= maxCapacity)
                        {
                            list[i] += n;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
