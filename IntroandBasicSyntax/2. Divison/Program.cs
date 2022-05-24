using System;

namespace _2._Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int divison = 0;
            if (number%10==0)
            {
                divison = 10;
            }
            else if (number%7==0)
            {
                divison= 7; 
            }
            else if(number %6==0)
            {
                divison = 6;
            }
            else if (number%3==0)
            {
                divison = 3;
            }
            else if (number%2==0)
            {
                divison = 2;
            }
            if (divison == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine("The number is divisible by "+divison);
            }
            
        }
    }
}
