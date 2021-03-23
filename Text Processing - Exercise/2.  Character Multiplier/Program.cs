using System;
using System.Linq;

namespace _2.__Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string firstInput = input[0];
            string secondInput = input[1];
            Console.WriteLine(SumOfCharacters(firstInput, secondInput));

        }
        static int SumOfCharacters(string str1, string str2) 
        {
            int sum = 0;
            int n = Math.Min(str1.Length, str2.Length);
            for (int i = 0; i < n; i++)
            {
                sum += str1[i] * str2[i];
            }
            if (str1.Length > str2.Length)
            {
                for (int i = n; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else
            {
                for (int i = n; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }

            return sum;
        }
    }
}
