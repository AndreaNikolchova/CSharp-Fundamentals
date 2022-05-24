using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            List<string> list = first.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            string line = Console.ReadLine();
            while (line != "end")
            {
                List<string> numberAndType = line.Split(' ').ToList();
                switch (numberAndType[0])
                {
                    case "Contains":
                        Contains(line,list);
                        break;
                    case "PrintEven":
                        PrintEven(line,list);
                        break;
                    case "PrintOdd":
                        PrintOdd(line,list);
                        break;
                    case "GetSum":
                        GetSum(line,list);
                        break;
                    case "Filter":
                        Filter(line, list);
                        break;
                    case "Add":
                        Add(line,list);
                        break;
                    case "Remove":
                        Remove(line,list);
                        break;
                    case "RemoveAt":
                        RemoveAt(line,list);
                        break;
                    case "Insert":
                        Insert(line,list);
                        break;

                }
                line = Console.ReadLine();
            }
            string result = String.Join(" ",list);
            if (first!=result)
            {
                Console.WriteLine(String.Join(" ",list));
            }
        }
        static void Contains(string line, List<string> list)
        {
            List<string> numberAndType = line.Split(' ').ToList();
            bool flag = false;
            foreach (string item in list)
            {
                if (numberAndType[1]==item)
                {
                     flag =  true;
                }
            }
            if (flag)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEven(string line, List<string> list)
        {
            List<string> number = new List<string>();
            foreach (string item in list)
            {
                if (int.Parse(item)%2==0)
                {
                    number.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",number));
        }
        static void PrintOdd(string line, List<string> list)
        {
            List<string> number = new List<string>();
            foreach (string item in list)
            {
                if (int.Parse(item) % 2 != 0)
                {
                    number.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", number));
        }
        static void GetSum(string line, List<string> list)
        {
            int sum = 0;
            foreach (string item in list)
            {
                sum += int.Parse(item);
            }
            Console.WriteLine(sum);
        }
        
        static void Filter(string line, List<string> list)
        {
            List<string> type = line.Split().ToList();
            List<string> number = new List<string>();
            List<string> Answer = new List<string>();
            switch (type[1])
            {
                case "<":
                    foreach (string item in list)
                    {
                        if (int.Parse(item)<int.Parse(type[2]))
                        {
                            Answer.Add(item);
                        }
                    }
                    Console.WriteLine(String.Join(" ",Answer));
                    break;
                case ">":
                    foreach(string item in list)
                    {
                        if (int.Parse(item) > int.Parse(type[2]))
                        {
                            Answer.Add(item);
                        }
                    }
                    Console.WriteLine(String.Join(" ", Answer));
                    break;
                case ">=":
                    foreach(string item in list)
                    {
                        if (int.Parse(item) >= int.Parse(type[2]))
                        {
                            Answer.Add(item);
                        }
                    }
                    Console.WriteLine(String.Join(" ", Answer));
                    break;
                case "<=":
                    foreach(string item in list)
                    {
                        if (int.Parse(item) <= int.Parse(type[2]))
                        {
                            Answer.Add(item);
                        }
                    }
                    Console.WriteLine(String.Join(" ", Answer));
                    break;
                
            }
            

        }
        static void Add(string line, List<string> listNumbers)
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
