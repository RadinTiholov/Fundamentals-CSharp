using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintMatrix(input);
        }
        static void PrintMatrix(int a) 
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(a + "");
                }
                Console.WriteLine();
            }
        }
    }
}
