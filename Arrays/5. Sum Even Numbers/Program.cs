using System;
using System.Linq;

namespace _5._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            foreach (int i in array)
            {
                if (i%2==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
