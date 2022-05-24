using System;
using System.Linq;

namespace _6._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum1 = 0;
            int sum2 = 0;
            
            for (int i =0 ; i < row.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sum1+=row[j];

                }
                for (int k = i; k < row.Length; k++)
                {
                    sum2+=row[k];
                }
                if (sum1==sum2-row[i])
                {
                    Console.WriteLine(i);
                    return;
                }
                sum2 = 0;
                sum1 = 0;

            }
            Console.WriteLine("no");
            

        }
    }
}
