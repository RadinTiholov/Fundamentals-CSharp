using System;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder help = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                help.Append(input[i]);
            }
            Console.WriteLine(help);
        }
    }
}
