using System;

namespace Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                arr[i] = a;
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(sum);
        }
    }
}
