using System;
using System.Linq;

namespace Methods___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(MinNumber(a, b, c));
        }
        static int MinNumber(int a, int b, int c)
        {
            int[] arr = new int[3] { a, b, c };
            return arr.Min();
        }
    }
}
