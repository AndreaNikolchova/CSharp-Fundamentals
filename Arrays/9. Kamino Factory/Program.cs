using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
           string imput = Console.ReadLine();
            int start = 0;
            int count = 0;
            int max = 0;
            int digit =0;
            int count1 = 0;
            while (imput != "Clone them!")
            {
                int[] array = imput.Split("!").Select(int.Parse).ToArray();
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        count++;
                        if (count > max)
                        {
                            start = i - count + 1;
                            max = count;
                            digit = array[i];
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                count1 = count;
                count = 0;
                

            }
        }
    }
}
