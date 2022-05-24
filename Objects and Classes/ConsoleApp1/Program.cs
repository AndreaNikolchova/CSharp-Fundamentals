using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
            public Person(string name, string id, int age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = age;
            }
        }
        static void CheckID(List<Person> list, List<string> command)
        {
          
            foreach (Person person in list)
            {
                if (person.ID == command[1])
                {
                    person.Name = command[0];
                    person.Age = int.Parse(command[2]);
                }
            }
        }
        static void Print(List<Person> list)
        {
            List<Person> list2 = list.OrderBy(x => x.Age).ToList();
            foreach (Person person in list2)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "End")
            {
                list.Add(new Person(command[0], command[1], int.Parse(command[2])));
                CheckID(list, command);
                command = Console.ReadLine().Split().ToList();
            }
            Print(list);
        }
    }
}
