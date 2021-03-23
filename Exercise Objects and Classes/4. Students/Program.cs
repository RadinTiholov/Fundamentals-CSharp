using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Dictionary<string, double>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ").ToArray();
                Dictionary<string, double> dict = new Dictionary<string, double>();
                string help = (input[0] + " " + input[1]).ToString();
                dict.Add(help, double.Parse(input[2]));
                list.Add(dict);
            }
            List<Dictionary<string, double>> sortedList = list.OrderBy(x => x.Values).ToList();
            Console.WriteLine(string.Join(" ", sortedList));
        }
    }
}
