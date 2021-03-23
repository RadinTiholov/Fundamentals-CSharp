using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var splitted = input.Split(" ");
                string name = splitted[0];
                if (splitted[1] == "is" && splitted[2] == "going!")
                {
                    if (!list.Contains(name))
                    {
                        list.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else if (splitted[1] == "is" && splitted[2] == "not" && splitted[3] == "going!")
                {
                    if (list.Contains(name))
                    {
                        list.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            //Console.WriteLine(string.Join(" ",list));
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
