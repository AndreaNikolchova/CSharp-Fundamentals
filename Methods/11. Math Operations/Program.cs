using System;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetNumbers();

        }
        static void GetNumbers()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            Calculate(type, firstNumber, secondNumber);

        }
        static void Calculate(string type, double one, double two)
        {
            switch (type)
            {
                case "/":
                    Console.WriteLine(one / two);
                    break;

                case "*":
                    Console.WriteLine(one * two);
                    break;
                case "+":
                    Console.WriteLine(one + two);
                    break;
                case "-":
                    Console.WriteLine(one - two);
                    break;
            }

        }


    }
}
