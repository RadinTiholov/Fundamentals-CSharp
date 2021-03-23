using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                var splitted = input.Split(" ");
                string command = splitted[0];
                if (command == "Chat")
                {
                    list.Add(splitted[1]);
                }
                else if (command == "Delete")
                {
                    string message = splitted[1];
                    if (list.Contains(message))
                    {
                        list.Remove(message);
                    }
                }
                else if (command == "Edit")
                {
                    string oldMessage = splitted[1];
                    string newMessage = splitted[2];
                    int index = list.IndexOf(oldMessage);
                    list.Remove(oldMessage);
                    list.Insert(index, newMessage);
                }
                else if (command == "Pin")
                {
                    string messege = splitted[1];
                    list.Remove(messege);
                    list.Add(messege);
                }
                else if (command == "Spam")
                {
                    for (int i = 1; i < splitted.Length; i++)
                    {
                        list.Add(splitted[i]);
                    }
                }


                input = Console.ReadLine();
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
