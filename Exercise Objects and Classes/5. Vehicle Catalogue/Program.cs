using System;
using System.Collections.Generic;
using System.Linq;


namespace _5._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicle> list = new List<Vehicle>();
            while (input != "End")
            {
                var splitted = input.Split(" ");
                string typeOfVehicle = splitted[0];
                string model = splitted[1];
                string color = splitted[2];
                int power = int.Parse(splitted[3]);

                var vihicle = new Vehicle(typeOfVehicle, model,color, power);
                list.Add(vihicle);

                input = Console.ReadLine();
            }
            string secondInput = Console.ReadLine();
            while (secondInput != "Close the Catalogue")
            {
                foreach (var item in list)
                {
                    if (secondInput == item.Model)
                    {
                        if (item.Type == "car")
                        {
                            Console.WriteLine($"Type: Car");
                        }
                        else if (item.Type == "truck")
                        {
                            Console.WriteLine($"Type: Truck");
                        }
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.Power}");
                    }
                }
                secondInput = Console.ReadLine();
            }
            double carSum = 0;
            double truckSum = 0;
            int countCar = 0;
            int countTruck = 0;
            foreach (var item in list.Where(x => x.Type == "car"))
            {
                carSum += item.Power;
                countCar++;
            }
            foreach (var item in list.Where(x => x.Type == "truck"))
            {
                truckSum += item.Power;
                countTruck++;
            }
            Console.WriteLine($"Cars have average horsepower of: {carSum/countCar:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckSum/countTruck:F2}.");
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int power)
        {
            Type = type;
            Model = model;
            Color = color;
            Power = power;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }
    }
}
