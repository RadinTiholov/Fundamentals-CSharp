using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                string help = a[i].ToString();
                int number = int.Parse(help);
                int fac = 1;
                for (int j = number; j > 0; j--)
                {
                     fac = fac * j;
                }
                sum += fac;
            }
            if (sum == int.Parse(a))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
