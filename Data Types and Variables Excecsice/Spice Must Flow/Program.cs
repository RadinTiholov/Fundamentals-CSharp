using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int day = 0;

            int leaving = 0;
            if (n < 100)
            {
                Console.WriteLine(day);
                Console.WriteLine(leaving);
                return;
            }
            while (n >= 100)
            {
                int yield = n;
                yield -= 26;
                leaving += yield;
                n -= 10;
                day++;

            }
            leaving -= 26;
            Console.WriteLine(day);
            Console.WriteLine(leaving);
        }
    }
}
