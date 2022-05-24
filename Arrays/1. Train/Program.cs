using System;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
               int number= int.Parse(Console.ReadLine());
                train[i] = number;
                sum += number;
            }
            Console.Write(String.Join(" ",train));
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
