using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();
            while (input != "Report")
            {
                var splitted = input.Split(" ");
                if (splitted[0] == "Blacklist")
                {
                    string name = splitted[1];
                    if (list.Contains(name))
                    {
                        int i = list.IndexOf(name);
                        list.RemoveAt(i);
                        list.Insert(i, "Blacklisted");
                        
                        Console.WriteLine($"{name} was blacklisted.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }

                }
                else if (splitted[0] == "Error")
                {
                    string name = list[int.Parse(splitted[1])];
                    if (name != "Blacklisted" && name != "Lost")
                    {
                        list.Insert(int.Parse(splitted[1]), "Lost");
                        list.RemoveAt(int.Parse(splitted[1]) + 1);
                        Console.WriteLine($"{name} was lost due to an error.");
                    }   
                }
                else if (splitted[0] == "Change")
                {
                    int index = int.Parse(splitted[1]);
                    string newName = splitted[2];
                    if (index >= 0 && index < list.Count)
                    {
                        list.Insert(index, newName);
                        string oldName = list[index + 1];
                        list.RemoveAt(index + 1);
                        Console.WriteLine($"{oldName} changed his username to {newName}.");
                    }
                }

                input = Console.ReadLine();
            }
            int black = 0;
            int lost = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "Blacklisted")
                {
                    black++;
                }
                if (list[i] == "Lost")
                {
                    lost++;
                }
            }
            Console.WriteLine($"Blacklisted names: {black}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
