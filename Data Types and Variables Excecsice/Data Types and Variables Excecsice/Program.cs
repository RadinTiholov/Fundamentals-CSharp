using System;

namespace Data_Types_and_Variables_Excecsice
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += int.Parse(n[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
