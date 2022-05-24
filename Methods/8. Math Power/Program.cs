using System;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(number,power));
        }
        static double MathPower(double number,double power)
        {
            double answer = 1;
            for (int i = 1; i <= power; i++)
            {
                answer *= number;
            }
            return answer;
        }

    }
}
