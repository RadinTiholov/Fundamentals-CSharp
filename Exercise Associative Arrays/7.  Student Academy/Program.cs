using System;
using System.Linq;
using System.Collections.Generic;

namespace _7.__Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, grade);
                }
                else
                {
                    dict[name] = (dict[name] + grade) / 2;
                }
            }
            var helpDict = dict.Where(x => x.Value >= 4.5)
                .OrderByDescending(x=>x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in helpDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
