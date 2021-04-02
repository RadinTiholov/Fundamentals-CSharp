using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_3._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> dict = new Dictionary<string, Hero>();

            for (int i = 0; i < n; i++)
            {
                var hero = Console.ReadLine().Split();
                Hero help = new Hero()
                {
                    HP = int.Parse(hero[1]),
                    MP = int.Parse(hero[2])
                };
                dict.Add(hero[0], help);
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                var splitted = input.Split(" - ");
                string command = splitted[0];
                string name = splitted[1];
                if (command == "Heal")
                {
                    int hp = int.Parse(splitted[2]);
                    int help = dict[name].HP;
                    dict[name].HP += hp;
                    if (dict[name].HP > 100)
                    {
                        dict[name].HP = 100;
                        Console.WriteLine($"{name} healed for {100-help} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} healed for {hp} HP!");
                    }
                }
                else if (command == "Recharge")
                {
                    int mp = int.Parse(splitted[2]);
                    int help = dict[name].MP;
                    dict[name].MP += mp;
                    if (dict[name].MP > 200)
                    {
                        dict[name].MP = 200;
                        Console.WriteLine($"{name} recharged for {200 - help} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} recharged for {mp} MP!");
                    }
                    
                }
                else if (command == "TakeDamage")
                {
                    int hp = int.Parse(splitted[2]);
                    string attacker = splitted[3];
                    dict[name].HP -= hp;
                    if (dict[name].HP > 0)
                    {
                        Console.WriteLine($"{name} was hit for {hp} HP by {attacker} and now has {dict[name].HP} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        dict.Remove(name);
                    }
                }
                else if (command == "CastSpell")
                {
                    int mp = int.Parse(splitted[2]);
                    string spell = splitted[3];
                    if (mp <= dict[name].MP)
                    {
                        dict[name].MP -= mp;
                        Console.WriteLine($"{name} has successfully cast {spell} and now has {dict[name].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
                    }
                }
                input = Console.ReadLine();
            }
            var sortted = dict.OrderByDescending(x => x.Value.HP).ThenBy(x => x.Key);
            foreach (var item in sortted)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($" HP: {item.Value.HP}");
                Console.WriteLine($" MP: {item.Value.MP}");
            }
        }
    }
    class Hero
    {
        public int HP { get; set; }
        public int MP { get; set; }
    }
}
