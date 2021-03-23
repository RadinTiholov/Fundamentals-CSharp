using System;

namespace __Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = n; i <= m; i++)
            {
                string output = ((char)i).ToString();
                Console.Write(output + " ");
            }
        }
    }
}
