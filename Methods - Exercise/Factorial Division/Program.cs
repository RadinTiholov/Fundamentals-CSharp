using System;
using System.Linq;


namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            FactorialToTwoNums(a,b);

        }
        static void FactorialToTwoNums(double a, double b) 
        {
            double aFact = 1;
            double bFact = 1;
            for (int i = 1; i <= a; i++)
            {
                aFact *= i;
            }
            for (int i = 1; i <= b; i++)
            {
                bFact *= i;
            }
            Console.WriteLine($"{aFact / bFact:F2}");
        }
    }
}
