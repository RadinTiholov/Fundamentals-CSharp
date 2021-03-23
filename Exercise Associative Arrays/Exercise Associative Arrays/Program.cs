using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise_Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
           
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (dict.ContainsKey(input[i]))
                    {
                        dict[input[i]]++;
                    }
                    else
                    {
                        dict.Add(input[i], 1);
                    }
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}
