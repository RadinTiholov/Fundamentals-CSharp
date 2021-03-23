using System;
using System.Linq;
using System.Collections.Generic;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int number = arr[0];
            int power = arr[1];

            int countOnRight = 0;
            int countOnLeft = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == number)
                {
                    for (int j = i; j < list.Count-1; j++)
                    {
                        countOnRight++;
                    }
                    if (power > countOnRight)
                    {
                        for (int j = i; j <= i + countOnRight; j++)
                        {
                            list[j] = 0;
                        }
                    }
                    else
                    {
                        for (int j = i; j <= i + power; j++)
                        {
                            list[j] = 0;
                        }
                    }
                    //
                    for (int j = i; j > 0; j--)
                    {
                        countOnLeft++;
                    }
                    if (power > countOnLeft)
                    {
                        for (int j = i; j >= i - countOnLeft; j--)
                        {
                            list[j] = 0;
                        }
                    }
                    else
                    {
                        for (int j = i; j >= i - power; j--)
                        {
                            list[j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(list.Sum());
        }
    }
}
