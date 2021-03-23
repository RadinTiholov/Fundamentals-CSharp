using System;
using System.Linq;
using System.Text;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(isPalindrome(input));
                input = Console.ReadLine();
            }
        }
        static string isPalindrome(string input) 
        {
            StringBuilder help = new StringBuilder();
            for (int i = input.Length -1; i >= 0; i--)
            {
                help.Append(input[i]);
            }
            if (help.ToString() == input)
            {
                return "true";
            }
            else
            {
                return "false";
            }
            
        }
    }
}
