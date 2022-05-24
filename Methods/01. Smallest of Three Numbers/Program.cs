using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindSmallest();
            
        }
        static void FindSmallest()
        {
            int min = int.MaxValue;
            for (int i = 1; i <= 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (min>number)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);

        }
    }
}
