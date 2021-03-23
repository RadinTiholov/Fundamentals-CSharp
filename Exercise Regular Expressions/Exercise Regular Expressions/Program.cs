using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @">>([A-Za-z\s]+)<<(\d+(.\d+)?)!([0-9])";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            double result = 0;
            List<string> list = new List<string>();
            while (input != "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string furniture = match.Groups[1].Value;
                    double sum = double.Parse(match.Groups[2].Value) * int.Parse(match.Groups[3].Value);
                    result += sum;

                    list.Add(furniture);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Bought furniture:");
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Total money spend: {result:F2}");
        }
    }
}
