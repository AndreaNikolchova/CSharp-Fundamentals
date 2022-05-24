using System;

namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string number = Console.ReadLine();
            int digit = int.Parse(number);
            int sum = 0;
            for (int i = 0; i <number.Length ; i++)
            {
                sum += digit %10;
                digit /=10;
               
            }
            Console.WriteLine(sum);
        }
    }
}
