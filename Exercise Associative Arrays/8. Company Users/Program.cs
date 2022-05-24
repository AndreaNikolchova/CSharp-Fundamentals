using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    internal class Program
    {
        class Company
        {
            public List<string> Id { get; set; }
            public Company(string id)
            {
                this.Id = new List<string>() {id};
            }

        }
        static void Main(string[] args)
        {
            Dictionary<string, Company> company = new Dictionary<string, Company>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else
                {
                    string[] line = command.Split(" -> ");
                    if (company.ContainsKey(line[0]))
                    {
                            if (!company.Any(x=>x.Value.Id.Contains(line[1])))
                            {
                                 company[line[0]].Id.Add(line[1]);
                            }
 
                    }
                    else
                    {
                        company.Add(line[0], new Company(line[1]));
                    }
                }
            }
            foreach(var item in company)
            {
                Console.WriteLine($"{item.Key}");
                for (int i = 0; i < item.Value.Id.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value.Id[i]}");
                }
            }
        }
    }
}
