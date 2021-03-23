using System;
using System.Text;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharBetweenTwo(a, b);
        }
        static void CharBetweenTwo(char firstNumber, char secondNumber) 
        {
            int a = Math.Min(firstNumber, secondNumber);
            int b = Math.Max(secondNumber, firstNumber);

            StringBuilder output = new StringBuilder();
            for (int i = a + 1; i < b; i++)
            {
                output.Append((char)i + " ");
            }
            Console.WriteLine(output);
        }
    }
}
