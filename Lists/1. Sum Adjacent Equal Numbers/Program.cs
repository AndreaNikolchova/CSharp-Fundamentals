using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count -1)
                {
                    break;
                }
                if (list [i]== list[i+1])
                {
                    list[i] = list[i] + list[i+1];
                    list.RemoveAt (i+1);
                    i = - 1;
                }
            }
            Console.WriteLine(String.Join(" ",list));
        }
    }
}
