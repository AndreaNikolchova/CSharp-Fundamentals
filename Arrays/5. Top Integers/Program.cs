using System;
using System.Linq;

namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = 0;
            bool flag = false;
            for (int i = 0; i < row.Length; i++)
            {
                if (flag)
                {
                    Console.Write(num + " ");
                }
                for (int j = i+1; j < row.Length; j++)
                {
                    if (row[i]>row[j])
                    {
                        flag = true;
                        num = row[i];
                    }
                    else
                    {
                        flag = false;
                        break;
                    } 
                }
            }
            Console.Write(row[row.Length-1]);
        }
    }
}
