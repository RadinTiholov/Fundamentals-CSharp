using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"^([$%])(?<tag>[A-Z][a-z]{2,})\1: \[(?<one>\d+)]\|\[(?<two>\d+)]\|\[(?<three>\d+)]\|$");
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    char one = (char)int.Parse(match.Groups["one"].Value);
                    char two = (char)int.Parse(match.Groups["two"].Value);
                    char three = (char)int.Parse(match.Groups["three"].Value);
                    Console.WriteLine($"{match.Groups["tag"]}: {one}{two}{three}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
