using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var list = new Dictionary<string, ShopInfo>();
            while (input != "buy")
            {
                var splitted = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = splitted[0];
                double price = double.Parse(splitted[1]);
                int quantity = int.Parse(splitted[2]);

                if (list.ContainsKey(name))
                {
                    list[name].Price = price;
                    list[name].Quantity += quantity;
                }
                else
                {
                    list.Add(name, new ShopInfo(price, quantity));
                }
                input = Console.ReadLine();
            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Price * item.Value.Quantity:F2}");
            }
        }
    }
    public class ShopInfo
    {
        public ShopInfo(double a, int b) 
        {
            Price = a;
            Quantity = b;
        }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
