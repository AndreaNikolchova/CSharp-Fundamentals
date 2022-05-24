using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n =int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];
            for (int i = 1; i <= n; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstNumber = row[0];
                int secondNumber = row[1];
                if (i%2==0)
                {
                    first[i-1] = secondNumber;
                    second[i-1] = firstNumber;
                }
                else
                {
                    first[i - 1] = firstNumber;
                    second[i - 1] = secondNumber;
                }
            }
            Console.WriteLine(String.Join(" ",first));
            Console.WriteLine(String.Join(" ",second));
        }
    }
}
