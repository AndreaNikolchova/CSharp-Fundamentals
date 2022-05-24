using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public float Grade { get; set; }
            public Student(string name, string lastName, float grade)
            {
                this.Name = name;
                this.LastName = lastName;
                this.Grade = grade;
            }


        }

        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                List<string> students = Console.ReadLine().Split(" ").ToList();
                Student student1 = new Student(students[0], students[1], float.Parse(students[2]));
                student.Add(student1);

            }

            List<Student> sortedStudents = student.OrderByDescending(t => t.Grade).ThenBy(t => t.Name).ThenBy(t => t.LastName).ToList();

            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine($"{sortedStudents[i].Name} {sortedStudents[i].LastName}: {sortedStudents[i].Grade:f2}");
            }

        }
    }
}
