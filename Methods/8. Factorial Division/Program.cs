using System;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            GetAnswer(firstNumber, secondNumber);
        }
        static double GetFacturielFirstNum(double first )
        {
            double sum = 1;
            for (double i = first; i >= 1; i--)
            {
                sum *= i;
            }
            return sum;
        }
        static double GetFacturielSecondNum(double second)
        {
            double sum = 1;
            for (double i = second; i >= 1; i--)
            {
                sum *= i;
            }
            return sum;
        }
        static void GetAnswer (double first, double second)
        {
            double answer =(GetFacturielFirstNum(first)/GetFacturielSecondNum(second));
            Console.WriteLine($"{answer:f2}");
        }
    }
}
