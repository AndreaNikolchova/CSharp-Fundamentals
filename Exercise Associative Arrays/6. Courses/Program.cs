using System;
using System.Collections.Generic;

namespace _6._Courses
{
    internal class Program
    {
        class Students
        {
           
            public List<string> StudentsNames { get; set; }
            public Students(string names)
            {
                this.StudentsNames = new List<string>(); 
                this.StudentsNames.Add(names);
            }
        }

        static void Main(string[] args)
        {
          
            Dictionary<string, Students> corses = new Dictionary<string,Students>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else
                {
                    string[] line = command.Split(" : ");
                    if (corses.ContainsKey(line[0]))
                    {
                        corses[line[0]].StudentsNames.Add(line[1]);
                    }
                    else
                    {
                        corses.Add(line[0], new Students(line[1]));
                    }
                }
            }
            foreach (var line in corses)
            {
                Console.WriteLine($"{line.Key}: {line.Value.StudentsNames.Count}");
                for (int i = 0; i < line.Value.StudentsNames.Count; i++)
                {
                    Console.WriteLine($"-- {line.Value.StudentsNames[i]}");
                }
            }
        }
    }
}
