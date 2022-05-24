using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[number];
            for (int i = arrayNumbers.Length -1; i >=0; i--)
            {
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write(arrayNumbers[i] + " ");
            }
             
        }
    }
}
