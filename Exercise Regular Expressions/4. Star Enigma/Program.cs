using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _4._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> attactedPlanets = new List<string>();
            List<string> destructedPlanets = new List<string>();
            
            Regex validator = new Regex(@"[STARstar]");
            Regex regex = new Regex(@"[^@\-!:>]*@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>[AD])![^@\-!:>]*->(?<soldiers>\d+)[^@\-!:>]*");
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                    var matches = validator.Matches(input);
                    int count = matches.Count();
                    string message = Decript(input, count);
                    if (regex.IsMatch(message))
                    {
                        Match match = regex.Match(message);
                        string planet = match.Groups["planet"].Value;
                        string type = match.Groups["type"].Value;
                        if (type == "A")
                        {
                            attactedPlanets.Add(planet);
                        }
                        else
                        {
                            destructedPlanets.Add(planet);
                        }
                    }
                
            }
            Console.WriteLine($"Attacked planets: {attactedPlanets.Count}");
            var sortedAt = attactedPlanets.OrderBy(x => x).ToList();
            foreach (var item in sortedAt)
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destructedPlanets.Count}");
            var sortedDe = destructedPlanets.OrderBy(x => x).ToList();
            foreach (var item in sortedDe)
            {
                Console.WriteLine($"-> {item}");
            }
        }

        private static string Decript(string input, int count)
        {
            StringBuilder text = new StringBuilder();
            foreach (var item in input)
            {
                text.Append((char)(item - count));
            }
            return text.ToString();
        }
    }
}
