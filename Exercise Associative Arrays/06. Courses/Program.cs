using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dict = new Dictionary<string, List<string>>();
            while (input != "end")
            {
                var splitted = input.Split(" : ");
                string course = splitted[0];
                string name = splitted[1];
                if (dict.ContainsKey(course))
                {
                    dict[course].Add(name);
                }
                else
                {
                    dict.Add(course, new List<string> { name });
                }

                input = Console.ReadLine();
            }
            var sortedDict = dict.OrderByDescending(x => x.Value.Count);
            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                List<string> list = item.Value;
                list.Sort();
                foreach (var name in list)
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
