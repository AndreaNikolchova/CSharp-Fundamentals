using System;

namespace _1._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber =double.Parse(Console.ReadLine());
            double secondNumber=double.Parse(Console.ReadLine());   
            double thirdNumber  =double.Parse(Console.ReadLine());
            double max = 1000000;
            double min = -1000000;
            double mid = 0;
            if (firstNumber>=secondNumber&&firstNumber>=thirdNumber)
            {
                max =firstNumber;
            }
            else if (secondNumber>=firstNumber&&secondNumber>=thirdNumber)
            {
                max=secondNumber;
            }
            else if (thirdNumber>=firstNumber&&thirdNumber>=secondNumber)
            {
                max=thirdNumber;
            }

            if (firstNumber<=secondNumber&&firstNumber<=thirdNumber)
            {
                min = firstNumber;
            }
            else if (secondNumber <= firstNumber && secondNumber <=thirdNumber)
            {
                min = secondNumber;
            }
            else if (thirdNumber <= firstNumber && thirdNumber <= secondNumber)
            {
                min=thirdNumber;
            }
            if (max>firstNumber&&firstNumber>min)
            {
                mid = firstNumber;
            }
            else if (max > secondNumber && secondNumber > min)
            {
                mid = secondNumber;
            }
            else if (max >thirdNumber && thirdNumber > min)
            {
                mid = thirdNumber;
            }
            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);
        }
    }
}
