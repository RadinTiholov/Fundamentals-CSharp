using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                var splitted = input.Split(" ");
                var person = new Person(splitted[0], int.Parse(splitted[1]), int.Parse(splitted[2]));
                list.Add(person);

                input = Console.ReadLine();
            }
            var sorted = list.OrderBy(x => x.Years);
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Years} years old.");
            }
        }
    }
    class Person 
    {
        public Person(string name,int Id, int years) 
        {
            Name = name;
            ID = Id;
            Years = years;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Years { get; set; }
    }
}
