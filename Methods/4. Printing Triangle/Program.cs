using System;

namespace _4._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
               GetLine(1,i);
            }
            for (int i = number; i >=1; i--)
            {
                GetLine(1,i);
            }
        }
        static void GetLine(int numberStart, int number)
        {
            for (int i = numberStart; i <= number; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
