using System;
using System.Text;
using System.Linq;

namespace Exam_prep4
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
                if (input.Contains("TakeOdd"))
                {
                    StringBuilder newText = new StringBuilder();
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            newText.Append(text[i]);
                        }
                    }
                    text = newText.ToString();
                    Console.WriteLine(text);
                }
                else if (input.Contains("Cut"))
                {
                    int index = int.Parse(splitted[1]);
                    int lenght = int.Parse(splitted[2]);
                    text = text.Remove(index, lenght);
                    Console.WriteLine(text);

                }
                else if (input.Contains("Substitute"))
                {
                    string substring = splitted[1];
                    string substitute = splitted[2];
                    if (text.Contains(substring))
                    {
                        while (text.Contains(substring))
                        {
                            text = text.Replace(substring, substitute);
                        }
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {text}");
        }
    }
}
