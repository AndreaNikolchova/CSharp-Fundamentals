using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine()); 
            Answer(SumOfFirstAndSecond(firstNumber,secondNumber),thirdNumber);
        }
        static int SumOfFirstAndSecond(int one,int second)
        {
            return one + second;
        }
        static void Answer(int sumResult, int third)
        {
            Console.WriteLine(sumResult -  third);
        }
    }
}
