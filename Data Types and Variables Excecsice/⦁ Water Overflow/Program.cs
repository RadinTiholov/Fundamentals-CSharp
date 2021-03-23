using System;

namespace __Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int waterTank = 0;
            for (int i = 0; i < n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                if (quantities + waterTank > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterTank += quantities;
                }
            }
            Console.WriteLine(waterTank);
        }
    }
}
