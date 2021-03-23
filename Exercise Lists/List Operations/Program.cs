using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "End")
            {
                var splitted = input.Split(" ");
                string command = splitted[0];
                if (command =="Add")
                {
                    if (int.Parse(splitted[1]) > list.Count || int.Parse(splitted[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Add(int.Parse(splitted[1]));
                    }
                }
                else if (command == "Insert")
                {
                    //(int.Parse(order[2]) >= 0 && int.Parse(order[2]) < numbers.Count)
                    if (int.Parse(splitted[2]) >= list.Count || int.Parse(splitted[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.Insert(int.Parse(splitted[2]), int.Parse(splitted[1]));
                    }
                }
                else if (command == "Remove")
                {
                    //(int.Parse(order[1]) < 0 || int.Parse(order[1]) >= numbers.Count
                    if (int.Parse(splitted[1]) >= list.Count || int.Parse(splitted[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        list.RemoveAt(int.Parse(splitted[1]));
                    }
                }
                else if (command == "Shift")
                {
                    if (splitted[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(splitted[2]); i++)
                        {
                            int firstNumber = list[0];
                            list.RemoveAt(0);
                            list.Add(firstNumber);
                        }
                    }
                    else if(splitted[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(splitted[2]); i++)
                        {
                            int lastNumber = list[list.Count-1];
                            list.RemoveAt(list.Count - 1);
                            list.Insert(0, lastNumber);
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
