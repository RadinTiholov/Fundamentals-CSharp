using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            var dict = new SortedDictionary<string, List<string>>();
            while (input != "End")
            {
                var splitted = input.Split(" -> ");
                string course = splitted[0];
                string name = splitted[1];
                if (dict.ContainsKey(course))
                {
                    if (!dict[course].Contains(name))
                    {
                        dict[course].Add(name);
                    }
                }
                else
                {
                    dict.Add(course, new List<string> { name });
                }

                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}");
                List<string> list = item.Value;
                //list.Sort();
                foreach (var name in list)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
