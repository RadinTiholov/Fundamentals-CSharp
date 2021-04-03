using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace PracticalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Done")
            {
                var splitted = input.Split(" ");
                string command = splitted[0];
                if (command == "Change")
                {
                    char letter = char.Parse(splitted[1]);
                    char replacment = char.Parse(splitted[2]);
                    text = text.Replace(letter, replacment);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string subString = splitted[1];
                    if (text.Contains(subString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "End")
                {
                    string subString = splitted[1];
                    if (text.EndsWith(subString))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char subChar = char.Parse(splitted[1]);
                    int help = text.IndexOf(subChar);
                    Console.WriteLine(help);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(splitted[1]);
                    int lenght = int.Parse(splitted[2]);
                    text = text.Substring(startIndex, lenght);
                    Console.WriteLine(text);
                }
                input = Console.ReadLine();
            }
        }
    }
}
