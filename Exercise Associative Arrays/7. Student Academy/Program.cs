using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Student_Academy
{
    internal class Program
    {
        class Students
        {
            public List<double> Grades { get; set; }
            public Students(double line)
            {
                this.Grades = new List<double>();
                this.Grades.Add(line);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Students> grades = new Dictionary<string, Students>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (grades.ContainsKey(name))
                {
                    grades[name].Grades.Add(grade);
                }
                else
                {
                    grades.Add(name, new Students(grade));
                }
            }
            foreach(var item in grades)
            {
                double sum = item.Value.Grades.Average();
                if (sum>=4.5)
                {
                    Console.WriteLine($"{item.Key} -> {sum:f2}");
                }
            }
        }
    }
}
