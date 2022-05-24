using System;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            switch (calculation)
            {
                case "add":
                    Console.WriteLine(Add(firstNumber, secondNumber));
                    break;
                case "multiply":
                    Console.WriteLine(Myltuply(firstNumber,secondNumber));
                    break;
                case "subtract":
                    Console.WriteLine(Substact(firstNumber,secondNumber));
                    break;
                case "divide":
                    Console.WriteLine(Divide(firstNumber,secondNumber));
                    break;
            }

        }
        static double Add(double first,double second)
        {
            return first + second;
        }
        static double Substact(double first, double second)
        {
            return first - second;
        }
        static double Myltuply(double first,double second)
        {
            return second * first;
        }
        static double Divide(double first,double second)
        {
            return first / second;
        }

    }
}
