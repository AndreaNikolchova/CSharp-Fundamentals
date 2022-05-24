using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapasity = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            while (line!="end")
            {
                List<string> list = line.Split().ToList();
                if (list[0]=="Add")
                {
                    passengers.Add(int.Parse(list[1]));

                }
                else
                {
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (int.Parse(list[0])+passengers[i]<=maxCapasity)
                        {
                            passengers[i] = passengers[i] + int.Parse(list[0]);
                            break;
                        }
                       
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",passengers));
        }
    }
}
