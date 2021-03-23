using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Vowelscount(input));
        }
        static int Vowelscount(string input) 
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'A' || input[i] == 'u' || input[i] == 'U' ||
                    input[i] == 'e' || input[i] == 'E' || input[i] == 'i' || input[i] == 'I'||
                    input[i] == 'o' || input[i] == 'O')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
