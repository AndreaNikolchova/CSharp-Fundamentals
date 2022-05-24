using System;
using System.Collections.Generic;

namespace _4._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 1; i <= length; i++)
            {
                list.Add(Console.ReadLine());
            }
            list.Sort();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i+1}.{list[i]}");
            }
        }
    }
}
