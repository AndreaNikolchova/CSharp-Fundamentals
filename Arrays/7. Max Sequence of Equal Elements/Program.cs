using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int count = 0;
            int max = 0;
            for (int i = 0; i < array1.Length -1; i++)
            {
                if (array1[i] == array1[i + 1])
                {
                    count++;
                    if (count > max)
                    {
                        start = i - count+1;
                        max = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = start; i <= start + max ; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();


        }
    }
}
