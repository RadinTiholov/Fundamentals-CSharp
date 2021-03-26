using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Problem_3._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Info> dict = new Dictionary<string, Info>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split("|");
                var info = new Info(input[1], input[2]);
                dict.Add(input[0], info);
            }
            string secondInput = Console.ReadLine();
            while (secondInput != "Stop")
            {
                var splitted = secondInput.Split("|");
                string command = splitted[0];
                if (command == "Add")
                {
                    string piece = splitted[1];
                    string composer = splitted[2];
                    string key = splitted[3];
                    if (dict.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        dict.Add(piece, new Info(composer, key));
                    }
                }
                else if (command == "Remove")
                {
                    string piece = splitted[1];
                    if (dict.ContainsKey(piece))
                    {
                        dict.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (command == "ChangeKey")
                {
                    string piece = splitted[1];
                    string newKey = splitted[2];
                    if (dict.ContainsKey(piece))
                    {
                        dict[piece].Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                secondInput = Console.ReadLine();
            }
            var sorted = dict.OrderBy(x => x.Key).ThenBy(x => x.Value.Composer);
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Key}");
            }

        }
    }
    class Info
    {
        public Info(string a, string b) 
        {
            Composer = a;
            Key = b;
        }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
