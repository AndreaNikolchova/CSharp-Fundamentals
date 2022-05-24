using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayNumbers = Console.ReadLine()
            .Split();
            Array.Reverse(arrayNumbers);
            Console.Write(String.Join(" ", arrayNumbers));
           
           
        }
    }
}
