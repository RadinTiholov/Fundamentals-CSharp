using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, People> dict = new Dictionary<string, People>();
            while (input != "Results")
            {
                var splitted = input.Split(":");
                string command = splitted[0];
                if (command == "Add")
                {
                    string name = splitted[1];
                    int health = int.Parse(splitted[2]);
                    int energy = int.Parse(splitted[3]);
                    if (dict.ContainsKey(name))
                    {
                        dict[name].Health += health;
                    }
                    else
                    {
                        dict.Add(name, new People() { Health = health, Energy = energy });
                    }
                }
                else if (command == "Attack")
                {
                    string attacker = splitted[1];
                    string deffender = splitted[2];
                    int damage = int.Parse(splitted[3]);
                    if (dict.ContainsKey(attacker) && dict.ContainsKey(deffender))
                    {
                        dict[deffender].Health -= damage;
                        if (dict[deffender].Health <= 0)
                        {
                            dict.Remove(deffender);
                            Console.WriteLine($"{deffender} was disqualified!");
                        }
                        dict[attacker].Energy--;
                        if (dict[attacker].Energy <= 0)
                        {
                            dict.Remove(attacker);
                            Console.WriteLine($"{attacker} was disqualified!");
                        }
                    }

                }
                else if (command == "Delete")
                {
                    string name = splitted[1];
                    if (name == "All")
                    {
                        dict.Clear();
                    }
                    else
                    {
                        if (dict.ContainsKey(name))
                        {
                            dict.Remove(name);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            var sortted = dict.OrderByDescending(x => x.Value.Health).ThenBy(x => x.Key);
            Console.WriteLine($"People count: {sortted.Count()}");
            foreach (var item in sortted)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Health} - {item.Value.Energy}");
            }
        }
    }
    class People 
    {
        public int Health { get; set; }
        public int Energy { get; set; }
    }
}
