using System;

namespace _4._Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number =int.Parse(Console.ReadLine());
            int end=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = number; i <=end; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum: " + sum);
        }
    }
}
