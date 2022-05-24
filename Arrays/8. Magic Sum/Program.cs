using System;
using System.Linq;

namespace _8._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < row.Length; i++)
            {
                for (int j = i+1; j < row.Length; j++)
                {
                    if (row[i] + row[j] == number)
                    {
                        Console.WriteLine($"{row[i]} {row[j]}");
                        break;
                    }
                }
            }
        }
    }
}
