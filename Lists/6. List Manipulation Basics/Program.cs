using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            •	Add { number}: add a number to the end of the list.
//•	Remove { number}: remove a number from the list.
//•	RemoveAt { index}: remove a number at a given index.
//•	Insert { number}{ index}: insert a number at a given index.
             List<string> list = Console.ReadLine().Split().ToList();
            string line = Console.ReadLine();
            while (line!="end")
            {
                List<string> numberAndType = line.Split(' ').ToList();
                switch (numberAndType[0])
                {
                    case "Add":
                        Add(line, list);
                        break;
                    case "Remove":
                        Remove(line, list);
                        break;
                    case "RemoveAt":
                        RemoveAt(line, list);
                        break;
                    case "Insert":
                        Insert(line, list);
                        break;
                }
                line = Console.ReadLine();  
            }
            Console.WriteLine(String.Join(" ",list));
        }
        static void Add(string line , List<string> listNumbers)
        {
           List<string> numberAndType = line.Split(' ').ToList();
           listNumbers.Add(numberAndType[1]);
        }
        static void Remove(string line, List<string> listNumbers)
        {
            List<string> numberAndType = line.Split(' ').ToList();
            listNumbers.Remove(numberAndType[1]);
        }
        static void RemoveAt(string line, List<string> listNumbers)
        {
            List<string> numberAndType = line.Split(' ').ToList();
            listNumbers.RemoveAt(int.Parse(numberAndType[1]));
        }
        static void Insert(string line, List<string> listNumbers)
        {
            List<string> numberAndType = line.Split(' ').ToList();
            listNumbers.Insert(int.Parse(numberAndType[2]), numberAndType[1]);
        }
    }
}
