using System;
using System.Text.RegularExpressions;
using System.Linq;


namespace Exam_prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Decode")
            {
                var splitted = command.Split('|');
                string comm = splitted[0];
                if (comm == "Move")
                {
                    int numbers = int.Parse(splitted[1]);
                    string subString = text.Substring(0, numbers);
                    text = text.Substring(numbers) + subString;

                }
                else if (comm == "Insert")
                {
                    int index = int.Parse(splitted[1]);
                    string value = splitted[2];
                    text = text.Insert(index, value);
                }
                else if (comm == "ChangeAll")
                {
                    string substring = splitted[1];
                    string replacement = splitted[2];
                    while (text.Contains(substring))
                    {
                        text = text.Replace(substring, replacement);
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {text}");
        }
    }
}
