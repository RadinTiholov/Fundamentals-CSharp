using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryDict = new Dictionary<string, int>()
            {
                {"shards",0 },
                {"fragments",0},
                {"motes",0}
            };
            Dictionary<string, int> junkDict = new Dictionary<string, int>();

            bool isWorking = true;
            string theCraftedItem = string.Empty;

            while (isWorking)
            {
                string input = Console.ReadLine();
                var splitted = input.Split(" ");
                for (int i = 0; i < splitted.Length; i= i +2)
                {
                    int count = int.Parse(splitted[i]);
                    string item = splitted[i+1].ToLower();
                    if (legendaryDict.ContainsKey(item))
                    {
                        legendaryDict[item] += count;
                        if (legendaryDict[item] >= 250)
                        {
                            legendaryDict[item] -= 250;
                            theCraftedItem = item;
                            isWorking = false;
                            break;
                        }
                    }
                    else
                    {
                        if (junkDict.ContainsKey(item))
                        {
                            junkDict[item] += count;
                        }
                        else
                        {
                            junkDict.Add(item, count);
                        }
                    }
                }

            }
            if (theCraftedItem == "shards")
            {
                Console.WriteLine("Shadowmourne obtained");
            }
            else if (theCraftedItem == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");

            }
            var sortedLegendary = legendaryDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in sortedLegendary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            var sortedJunk = junkDict
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in sortedJunk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
