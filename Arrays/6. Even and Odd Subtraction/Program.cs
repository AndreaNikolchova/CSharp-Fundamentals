using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
           int sumEven = 0,sumOdd =0;
            foreach (int i in array)
            {
                if (i%2==0)
                {
                    sumEven += i;
                }
                else
                {
                    sumOdd += i;
                }
            }
            Console.WriteLine(sumEven-sumOdd);
        }
    }
}
