using System;

namespace VENDING_mACHINE_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;
            while (input != "Start")
            {
                double help = double.Parse(input);
                if (help != 0.1 && help != 0.2 && help != 0.5 && help != 1 && help != 2)
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                else
                {
                    sum += help;
                }
                input = Console.ReadLine();
            }
            string secondInput = Console.ReadLine();
            while (secondInput != "End")
            {
                if (secondInput == "Nuts")
                {
                    int help = 2;
                    if (sum >= help)
                    {
                        sum -= help;
                        Console.WriteLine($"Purchased nuts");
                    }
                }
                else if (secondInput == "Water")
                {
                    double help = 0.7;
                    if (sum >= help)
                    {
                        sum -= help;
                        Console.WriteLine($"Purchased water");
                    }
                }
                else if (secondInput == "Crisps")
                {
                    double help = 1.5;
                    if (sum >= help)
                    {
                        sum -= help;
                        Console.WriteLine($"Purchased crisps");
                    }
                }
                else if (secondInput == "Soda")
                {
                    double help = 0.8;
                    if (sum >= help)
                    {
                        sum -= help;
                        Console.WriteLine($"Purchased soda");
                    }
                }
                else if (secondInput == "Coke")
                {
                    double help = 1;
                    if (sum >= help)
                    {
                        sum -= help;
                        Console.WriteLine($"Purchased coke");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                secondInput = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");

        }
    }
}
