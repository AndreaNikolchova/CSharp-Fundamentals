using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
          List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> resultList = new List<int>{};
            int list = 0;
            if (firstList.Count>secondList.Count)
            {
                list = firstList.Count;
            }
            else
            {
                list= secondList.Count;
            }
            for (int i = 0; i < list; i++)
            {
                if (i<firstList.Count)
                {
                    resultList.Add(firstList[i]);
                }
                if (i<secondList.Count)
                {
                    resultList.Add(secondList[i]);
                }

            }
            Console.WriteLine(String.Join(" ",resultList));
        }
    }
}
