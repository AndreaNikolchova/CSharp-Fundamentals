using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int listCapasity = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < listCapasity; i++)
            {
                string line = Console.ReadLine();
                List<string> listLine = line.Split().ToList();
                if (listLine[2] == "going!")
                {
                    Going(names,listLine);

                }
                else if (listLine[2]=="not")
                {
                    NotGoing(names, listLine);
                }
                
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        static void CheckNameGoing(List<string> names , List<string> line)
        {
            foreach (var i in names)
            {
                if (i==line[0])
                {
                    Console.WriteLine($"{line[0]} is already in the list!");
                }
            }
        }
        static void Going(List<string> names, List<string> line)
        {
            bool flag  = true;
            
                foreach (var i in names)
                {
                    if (i == line[0])
                    {
                        flag = false;
                    }
                }
            if (!flag)
            {
                Console.WriteLine($"{line[0]} is already in the list!");
            }
            else
            {
                names.Add(line[0]);
            }

        }
        static void NotGoing(List<string> names, List<string> line)
        {
            bool flag = true;
            foreach (var i in names)
            {
                if (i == line[0])
                {
                    flag = false;
                }
            }
            if (!flag)
            {
                names.Remove(line[0]);
                
            }
            else
            {
                Console.WriteLine($"{line[0]} is not in the list!");
            }
        }
        
    }
}
