using System;
using System.Linq;
using System.Collections.Generic;

namespace _9._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> dict = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                var splitted = input.Split();
                string command = splitted[1];
                string forceUser = string.Empty;
                string forceSide = string.Empty;

                if (command == "|")
                {
                    forceSide = splitted[0];
                    forceUser = splitted[2];
                    if (dict.ContainsKey(forceSide))
                    {
                        dict[forceSide].Add(forceUser);
                    }
                    else
                    {
                        dict.Add(forceSide, new HashSet<string> { forceUser });
                    }
                    
                }
                else if (command == "->")
                {

                    forceSide = splitted[2];
                    forceUser = splitted[0];

                }

                input = Console.ReadLine();
            }
            var orderedDict = dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);
            foreach (var item in orderedDict)
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var name in item.Value)
                {
                    Console.WriteLine($"!{name}");
                }
            }

        }
    }
}
