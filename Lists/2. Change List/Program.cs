using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> numbers = Console.ReadLine().Split().ToList();
            string line = Console.ReadLine();
            while (line!= "end")
            {
                List<string> type = line.Split().ToList();
                if (type[0]=="Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(type[1]);
                    }
                }
                else if (type[0]=="Insert")
                {
                    numbers.Insert(int.Parse(type[2]), type[1]);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
