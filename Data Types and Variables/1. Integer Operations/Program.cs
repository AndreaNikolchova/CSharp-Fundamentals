using System;

namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            long fourthNumber = long.Parse(Console.ReadLine());
            firstNumber += secondNumber;
            firstNumber /= thirdNumber;
            firstNumber *= fourthNumber;
            Console.WriteLine(firstNumber);
        }
    }
}
