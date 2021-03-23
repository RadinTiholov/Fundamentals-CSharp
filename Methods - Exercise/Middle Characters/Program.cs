using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            FindTheMiddleChar(input);
        }
        static void FindTheMiddleChar(string input) 
        {
            if (input.Length % 2 == 0)
            {
                Console.Write(input[input.Length / 2 - 1]);
                Console.WriteLine(input[input.Length / 2]);
                
            }
            else
            {
                Console.WriteLine(input[input.Length / 2]);
            }
            
        }
    }
}
