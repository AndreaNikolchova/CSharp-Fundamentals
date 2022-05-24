using System;

namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            switch (type)
            {
                case "int":
                    CompereInt(first, second);
                    break;
                case "char":
                    CompereChar(first, second);
                    break;
                case "string":
                    CompereString(first,second);
                    break;
            }

        }
        static void CompereInt( string one, string two)
        {
            int first =int.Parse(one);
            int second =int.Parse(two);
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else if (second > first)
            {
                Console.WriteLine(second);
            }   
       
        }
        static void CompereString(string one,string two)
        {
            int comparison = String.Compare(one,two,StringComparison.OrdinalIgnoreCase);
            if (comparison>0)
            {
                Console.WriteLine(one);
            }
            else if (comparison<0)
            {
                Console.WriteLine(two);
            }
        }
        static void CompereChar(string one,string two)
        {
            char first =char.Parse(one);
            char second =char.Parse(two);
            int comparison = first.CompareTo(second);
            if (comparison<0)
            {
                Console.WriteLine(second);
            }
            else if (comparison>0)
            {
                Console.WriteLine(first);
            }
        }

    }
}
