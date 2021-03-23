using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"%(?<name>[A-Z][a-z]+)%([^|$%.]+)?<(?<product>\w+)>([^|$%.]+)?\|(?<count>\d*)\|([^|$%.\d]+)?(?<price>\d+(.\d+)?)\$";
            Regex regex = new Regex(pattern);
            double totalIncome = 0;

            while (input != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    Console.WriteLine($"{name}: {product} - {count*price:F2}");
                    totalIncome += count * price;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
