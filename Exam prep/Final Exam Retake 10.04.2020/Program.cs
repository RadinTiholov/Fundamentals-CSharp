using System;
using System.Linq;
using System.Text;

namespace Final_Exam_Retake_10._04._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Reveal")
            {
                var splitted = input.Split(":|:");
                if (splitted[0] == "InsertSpace")
                {
                    int index = int.Parse(splitted[1]);
                    text = text.Insert(index, " ");
                    Console.WriteLine(text);
                }
                else if (splitted[0] == "Reverse")
                {
                    string subString = splitted[1];
                    if (text.Contains(subString))
                    {
                        int index = text.IndexOf(subString);
                        text = text.Remove(index, subString.Length);
                        string help = Reverse(subString);
                        text += help;
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (splitted[0] == "ChangeAll")
                {
                    char subString = char.Parse(splitted[1]);
                    char replacement = char.Parse(splitted[2]);
                    text = text.Replace(subString, replacement);
                    Console.WriteLine(text);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {text}");
            
        }

        private static string Reverse(string subString)
        {
            StringBuilder text = new StringBuilder();
            for (int i = subString.Length-1; i >= 0; i--)
            {
                text.Append(subString[i]);
            }
            return text.ToString();

        }
    }
}
