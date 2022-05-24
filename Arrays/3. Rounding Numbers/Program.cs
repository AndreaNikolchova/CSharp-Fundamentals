using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float[] arrayNumbers = Console.ReadLine()
                .Split()
               .Select(float.Parse)
                .ToArray();
            for (int i = 0; i <arrayNumbers.Length; i++)
            {
                Console.WriteLine(arrayNumbers[i]+ " => " + Math.Round(arrayNumbers[i],MidpointRounding.AwayFromZero));
            }
            
        }
    }
}
