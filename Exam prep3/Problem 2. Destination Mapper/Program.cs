using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_2._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([\/=])(?<name>[A-Z][A-Za-z]{2,})\1");
            MatchCollection matches = regex.Matches(input);
            int sum = 0;
            List<string> list = new List<string>();
            foreach (Match item in matches)
            {
                sum += item.Groups["name"].Length;
                list.Add(item.Groups["name"].ToString());
            }
            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
