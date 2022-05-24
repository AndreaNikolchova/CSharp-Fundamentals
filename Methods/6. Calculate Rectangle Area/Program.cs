using System;

namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firstNumber = int.Parse(Console.ReadLine());
           int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetS(firstNumber,secondNumber));
        }
        static int GetS(int height, int weight)
        {
            return height * weight;
        }
    }
}
