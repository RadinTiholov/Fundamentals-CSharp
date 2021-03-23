using System;
using System.Linq;

namespace _4.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int number = (int)input[i] + 3;
                arr[i] = (char)number;
            }
            foreach (var item in arr)
            {
                Console.Write(item);
            }
        }
    }
}
