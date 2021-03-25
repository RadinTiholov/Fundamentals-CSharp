using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Problem_2._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([#\|])(?<itemName>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1");
            var matces = regex.Matches(input);
            int sumOfCalories = 0;
            foreach (Match item in matces)
            {
                sumOfCalories += int.Parse(item.Groups["calories"].Value);
            }
            Console.WriteLine($"You have food to last you for: {sumOfCalories/2000} days!");
            foreach (Match item in matces)
            {
                Console.WriteLine($"Item: {item.Groups["itemName"].Value}, Best before: {item.Groups["date"].Value}, Nutrition: {item.Groups["calories"].Value}");
            }
        }
    }
}
