using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dict = new Dictionary<string, int>();
            int count = 1;

            string help = "";
            while (input != "stop")
            {
                if (count % 2 == 1)
                {
                    help = input;
                }
                else
                {
                    if (!dict.ContainsKey(help))
                    {
                        dict.Add(help, int.Parse(input));
                    }
                    else
                    {
                        dict[help] += int.Parse(input);
                    }
                    
                }

                count++;
                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
