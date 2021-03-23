using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            double priceOfSabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double additinalLightSabers = Math.Ceiling(0.10 * count);

            double totalLightSabers = (count + additinalLightSabers) * priceOfSabers;
            double totalRobes = priceOfRobes * count;

            double freeBelts = Math.Floor(count / 6.00);
            double totalBelts = priceOfBelts * (count - freeBelts);

            double moneyNeeded = totalBelts + totalLightSabers + totalRobes;
            if (money >= moneyNeeded)
            {

                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                double moneyDiff = moneyNeeded - money;
                Console.WriteLine($"Ivan Cho will need {moneyDiff:f2}lv more.");
            }
        }
    }
}
