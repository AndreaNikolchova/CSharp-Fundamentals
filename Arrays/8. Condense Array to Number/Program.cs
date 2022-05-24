using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
           int first = arrayOne.Length; 
            for (int i = 0; i < first -1; i++)
            {
                int[] nums = new int[arrayOne.Length - 1];
                for (int j = 0; j < arrayOne.Length -1; j++)
                {
                    nums[j] = arrayOne[j] + arrayOne[j+1];

                }
                arrayOne = nums;
            }
            Console.WriteLine(arrayOne[0]);
            
        }
    }
}
