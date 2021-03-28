using System;
using System.Linq;
using System.Collections.Generic;


namespace Exam_prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Info>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split("<->");
                string plant = tokens[0];
                int rarity = int.Parse(tokens[1]);
                if (dict.ContainsKey(plant))
                {
                    dict[plant].Rarity = rarity;
                }
                else
                {
                    dict.Add(plant, new Info { Rarity = rarity , RatingList = new List<double>(), Average = 0});
                }
            }
            var input = Console.ReadLine();
            while (input != "Exhibition")
            {
                var splitted = input.Split();
                string command = splitted[0];
                string plant = splitted[1];
                if (command == "Rate:")
                {
                    if (dict.ContainsKey(plant))
                    {
                        double rating = double.Parse(splitted[3]);
                        dict[plant].RatingList.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Update:")
                {
                    if (dict.ContainsKey(plant))
                    {
                        int newRarity = int.Parse(splitted[3]);
                        dict[plant].Rarity = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Reset:")
                {
                    if (dict.ContainsKey(plant))
                    {
                        dict[plant].RatingList.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in dict)
            {
                double average = item.Value.RatingList.Sum();
                average = average / item.Value.RatingList.Count;
                if (Double.IsNaN(average))
                {
                    average = 0;
                }
                item.Value.Average = average;
            }

            var sorted = dict.OrderByDescending(x => x.Value.Rarity).ThenByDescending(x => x.Value.Average);
            foreach (var item in sorted)
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {item.Value.Average:F2}");
            }
            
        }
    }
    class Info 
    {
        public int Rarity { get; set; }
        public List<double> RatingList { get; set; }

        public double Average { get; set; }
    }
}
