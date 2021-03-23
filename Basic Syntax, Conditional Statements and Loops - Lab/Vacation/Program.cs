using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string grouptype = Console.ReadLine();
            string  day = Console.ReadLine();

            double price = 0;
            switch (grouptype)
            {
                case ("Students"):
                    switch (day)
                    {
                        case ("Friday"):
                            price = 8.45;
                            break;
                        case ("Saturday"):
                            price = 9.80;
                            break;
                        case ("Sunday"):
                            price = 10.46;
                            break;
                    }
                    break;
                case ("Business"):
                    switch (day)
                    {
                        case ("Friday"):
                            price = 10.90;
                            break;
                        case ("Saturday"):
                            price = 15.60;
                            break;
                        case ("Sunday"):
                            price = 16;
                            break;
                    }
                    break;
                case ("Regular"):
                    switch (day)
                    {
                        case ("Friday"):
                            price = 15;
                            break;
                        case ("Saturday"):
                            price = 20;
                            break;
                        case ("Sunday"):
                            price = 22.50;
                            break;
                    }
                    break;
            }
            double totalPrice = n * price;
            if (n >= 30 && grouptype == "Students")
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }
            else if (n >= 100 && grouptype == "Business")
            {
                totalPrice = totalPrice - 10 * price;
            }
            else if (n >= 10 && n <= 20 && grouptype == "Regular")
            {
                totalPrice = totalPrice - totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
