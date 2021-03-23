using System;
using System.Linq;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                   .Split(@"\", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();
            foreach (var item in input)
            {
                if (item.Contains('.'))
                {
                    var splitted = item.Split('.');
                    Console.WriteLine($"File name: {splitted[0]}");
                    Console.WriteLine($"File extension: {splitted[1]}");
                }
            }
        }
    }
}
