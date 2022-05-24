using System;

namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string drink = Console.ReadLine();
            decimal  cuontity = decimal.Parse(Console.ReadLine());
            switch (drink)
            {
               
                case "coffee":
                    GetCoffee(cuontity);
                    break;
                case "water":
                    GetWater(cuontity);
                    break;
                case "coke":
                    GetCoke(cuontity);
                    break;
                case "snacks":
                    GetSnacks(cuontity);
                    break;

            }



        }
        static void GetCoffee (decimal number)
        {
            Console.WriteLine($"{(number * (decimal)1.50):f2}");
        }
        static void GetWater(decimal number)
        {
            Console.WriteLine($"{(number * (decimal)1.00):f2}");
        }
        static void GetCoke(decimal number)
        {
            Console.WriteLine($"{(number * (decimal)1.40):f2}");
        }
        static void GetSnacks(decimal number)
        {
            Console.WriteLine($"{(number * (decimal)2.00):f2}");
        }

    }
}
