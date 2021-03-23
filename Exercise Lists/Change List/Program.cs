using System;
using System.Linq;
using System.Collections.Generic;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                var splitted = input.Split(" ");
                if (input.Contains("Delete"))
                {
                    int n = int.Parse(splitted[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == n)
                        {
                            list.Remove(list[i]);
                        }
                    }
                }
                else if (input.Contains("Insert"))
                {
                    int element = int.Parse(splitted[1]);
                    int position = int.Parse(splitted[2]);
                    list.Insert(position,element);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
