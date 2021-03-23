using System;
using System.Linq;
using System.Collections.Generic;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                double pricecForCaps = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());

                double sum = ((days * count) * pricecForCaps);
                totalSum += sum;
                Console.WriteLine($"The price for the coffee is: ${sum:F2}");
            }
            Console.WriteLine($"Total: ${totalSum:F2}");
        }
    }
}
