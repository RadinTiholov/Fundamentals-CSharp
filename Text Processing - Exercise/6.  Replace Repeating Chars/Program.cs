using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace _6.__Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> list = Console.ReadLine().ToList();

            for (int i = 1; i <list.Count; i++)
            {
                if (list[i] == list[i-1])
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join("", list));
        }
    }
}
