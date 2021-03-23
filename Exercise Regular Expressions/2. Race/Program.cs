using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(", ").ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in names)
            {
                dict.Add(item, 0);
            }

            string pattern1 = @"[A-Za-z]";
            Regex regexForLetters = new Regex(pattern1);

            string pattern2 = @"\d";
            Regex regexForDigits = new Regex(pattern2);


            string input = Console.ReadLine();
            while (input != "end of race")
            {
                var letterMatch = regexForLetters.Matches(input);
                StringBuilder name = new StringBuilder();
                foreach (var letter in letterMatch)
                {
                    name.Append(letter);
                }

                var digitMatch = regexForDigits.Matches(input);
                int distance = 0;
                foreach (var item in digitMatch)
                {
                    distance += int.Parse(item.ToString());
                }

                if (dict.ContainsKey(name.ToString()))
                {
                    dict[name.ToString()] += distance;
                }

                input = Console.ReadLine();
            }
            var sortedDict = dict.OrderByDescending(x => x.Value).Take(3);
            int count = 1;
            foreach (var item in sortedDict)
            {
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                count++;
            }
        }
    }
}
