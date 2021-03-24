using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_3._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> dict = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var cars = Console.ReadLine().Split("|");
                string car = cars[0];
                int mileage = int.Parse(cars[1]);
                int fuel = int.Parse(cars[2]);
                var carProp = new Car() {Mileage = mileage, Fuel = fuel };
                dict.Add(car, carProp);
            }
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                var splitted = input.Split(" : ");
                string command = splitted[0];
                if (command == "Drive")
                {
                    string car = splitted[1];
                    int distance = int.Parse(splitted[2]);
                    int fuel = int.Parse(splitted[3]);
                    if (dict[car].Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        dict[car].Mileage += distance;
                        dict[car].Fuel -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (dict[car].Mileage >= 100000)
                    {
                        dict.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (command == "Refuel")
                {
                    string car = splitted[1];
                    int fuel = int.Parse(splitted[2]);//40
                    int help = 75 - dict[car].Fuel;// 74 + 40 = 114

                    dict[car].Fuel += fuel;
                    if (dict[car].Fuel > 75)
                    {
                        dict[car].Fuel = 75;
                        Console.WriteLine($"{car} refueled with {help} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                    

                }
                else if (command == "Revert")
                {
                    string car = splitted[1];
                    int kilometers = int.Parse(splitted[2]);
                    dict[car].Mileage -= kilometers;

                    if (dict[car].Mileage < 10000)
                    {
                        dict[car].Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }

                }

                input = Console.ReadLine();
            }
            var sortedDict = dict.OrderByDescending(x => x.Value.Mileage).ThenBy(x => x.Key);
            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }
    public class Car 
    {
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
