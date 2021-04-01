using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_1._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Travel")
            {
                var splitted = input.Split(':');
                string command = splitted[0];
                if (command == "Add Stop")
                {
                    int index = int.Parse(splitted[1]);
                    string subString = splitted[2];
                    if (index >= 0 && index < text.Length)
                    {
                        text = text.Insert(index, subString);
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Remove Stop")
                {
                    int index = int.Parse(splitted[1]);
                    int endIndex = int.Parse(splitted[2]);

                    if (index >= 0 && endIndex >= 0 && endIndex <= text.Length - 1)
                    {
                        text = text.Remove(index, endIndex - index + 1);
                    }
                    Console.WriteLine(text);

                }
                else if (command == "Switch")
                {
                    string oldString = splitted[1];
                    string newString = splitted[2];
                    if (text.Contains(oldString))
                    {

                        text = text.Replace(oldString, newString);

                    }
                    Console.WriteLine(text);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}

