using System;

namespace __Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double theBiggest = 0;
            string theBiggestString = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                if (volume > theBiggest)
                {
                    theBiggest = volume;
                    theBiggestString = model;
                }
            }
            Console.WriteLine(theBiggestString);
        }
    }
}
