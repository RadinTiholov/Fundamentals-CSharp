using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if (Sum(input) % 8 == 0 && AreThereAnyOddDigits(input))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static int Sum(int input)
        {
            int sum = 0;
            while (input != 0)
            {
                int lastDigit = input % 10;
                sum += lastDigit;

                input /= 10;
            }

            return sum;
        }

        static bool AreThereAnyOddDigits(int input)
        {
            string help = input.ToString();
            for (int i = 0; i < help.Length; i++)
            {
                if ((int)help[i] % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
