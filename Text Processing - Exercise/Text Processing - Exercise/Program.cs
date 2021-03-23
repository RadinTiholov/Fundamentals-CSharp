using System;
using System.Text;
using System.Linq;

namespace Text_Processing___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length >= 3 && input[i].Length <= 16)
                {
                    if (isValid(input[i]))
                    {
                        Console.WriteLine(input[i]);
                    }

                }
            }
        }
        public static bool isValid(string str) 
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (char.IsLetterOrDigit(str[j]) || str[j] == '-' || str[j] == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
