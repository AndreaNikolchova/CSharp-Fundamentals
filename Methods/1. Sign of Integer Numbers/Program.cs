using System;

namespace _1._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SeeNumber(number);
        }
        static void SeeNumber(int number)
        {
            if (number <0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
