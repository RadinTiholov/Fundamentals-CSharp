using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "course start")
            {
                var splitted = input.Split(":");
                string lesson = splitted[1];
                if (input.Contains("Add"))
                {
                    if (!list.Contains(lesson))
                    {
                        list.Add(lesson);
                    }
                }
                else if (input.Contains("Insert"))
                {
                    int index = int.Parse(splitted[2]);
                    if (!list.Contains(lesson))
                    {
                        list.Insert(index, lesson);
                    }
                }
                else if (input.Contains("Remove"))
                {
                    if (list.Contains(lesson))
                    {
                        list.Remove(lesson);
                        if (list.Contains(lesson + "-Exercise"))
                        {
                            list.Remove(lesson + "-Exercise");
                        }
                    }
                }
                else if (input.Contains("Swap"))
                {
                    string lesson1 = splitted[1];
                    string lesson2 = splitted[2];
                    if (list.Contains(lesson1) && list.Contains(lesson2))
                    {
                        int index1 = list.IndexOf(lesson1);
                        int index2 = list.IndexOf(lesson2);
                        list.Remove(lesson2);
                        list.Remove(lesson1);
                        list.Insert(index1, lesson2);
                        list.Insert(index2, lesson1);
                        if (list.Contains(lesson1 + "-Exercise"))
                        {
                            list.Remove(lesson1 + "-Exercise");
                            list.Insert(index2 + 1, lesson1 + "-Exercise");
                        }
                        if (list.Contains(lesson2 + "-Exercise"))
                        {
                            list.Remove(lesson2 + "-Exercise");
                            list.Insert(index1 + 1, lesson2 + "-Exercise");
                        }
                    }
                }
                else if (input.Contains("Exercise"))
                {
                    if (list.Contains(lesson) && list.Contains(lesson + "-Exercise"))
                    {
                        list.Add(lesson + "-Exercise");
                    }
                    else if (!list.Contains(lesson))
                    {
                        list.Add(lesson);
                        list.Add(lesson + "-Exercise");
                    }
                }
                input = Console.ReadLine();
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
