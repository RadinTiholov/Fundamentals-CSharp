using System;

namespace __Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int peopleByCourse = n / capacity;
            if (n % capacity == 0)
            {
                Console.WriteLine(peopleByCourse);
            }
            else
            {
                Console.WriteLine(peopleByCourse + 1);
            }
        }
    }
}
