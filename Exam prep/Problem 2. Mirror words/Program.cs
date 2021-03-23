using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Problem_2._Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(?<group1>[@#])(?<firstWord>[A-Za-z]{3,})(\k<group1>)(?<group2>[@#])(?<secondWord>[A-Za-z]{3,})(\k<group2>)");

            Dictionary<string, string> list = new Dictionary<string, string>();
            if (regex.IsMatch(input))
            {
                var matches = regex.Matches(input);
                foreach (Match item in matches)
                {
                    string reversedWord = Reverse(item.Groups["secondWord"].Value);
                    if (item.Groups["firstWord"].Value == reversedWord)
                    {
                        list.Add(item.Groups["firstWord"].Value, item.Groups["secondWord"].Value);
                    }
                }
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            if (list.Count <= 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");
                string[] help = new string[list.Count];
                int i = 0;
                foreach (var item in list)
                {
                    help[i] = $"{item.Key} <=> {item.Value}";
                    i++;
                }
                Console.WriteLine(string.Join(", ", help));
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
