using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<string> list = Console.ReadLine().Split().ToList();
            string line = Console.ReadLine();
            while (line != "End")
            {
                List<string> numberAndType = line.Split(' ').ToList();
                switch (numberAndType[0])
                {
                    case "Add":
                        Add(list, numberAndType);
                        break;
                    case "Remove":
                        Remove(list, numberAndType);
                        break;
                    case "Insert":
                        Insert(list, numberAndType);
                        break;
                    case "Shift":
                        if (numberAndType[1] == "right")
                        {
                            ShiftRight(list, numberAndType);
                        }
                        else
                        {
                            ShiftLeft(list, numberAndType);
                        }
                        break;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", list));


        }
        static void Add(List<string> numbers, List<string> line)
        {
            numbers.Add(line[1]);
        }
        static void Insert(List<string> numbers, List<string> line)
        {
            numbers.Insert(int.Parse(line[2]),line[1]);
        }
        static void Remove(List<string> numbers, List<string> line)
        {
            numbers.RemoveAt(int.Parse(line[1]));
        }
        static void ShiftLeft(List<string> numbers, List<string> line)
        {
            for (int i = 0; i < numbers.Count-1; i++)
            {
                numbers.Insert(int.Parse(line[2])-1, numbers[i]);
                numbers.RemoveAt(i);
            }  
        }
        static void ShiftRight(List<string> numbers, List<string> line)
        {
            for (int i = 0; i < int.Parse(line[2]); i++)
            {
                numbers.Insert(int.Parse(line[2]), numbers[numbers.Count - 1 - i]);
            }
        }
    }
}
