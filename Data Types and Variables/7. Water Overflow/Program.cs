using System;

namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int liters = 0;
            int sumLiters = 0;
            for (int i = 1; i <= n; i++)
            {
                liters = int.Parse(Console.ReadLine());
                 sumLiters += liters;

              
                if ((sumLiters-liters>liters&& sumLiters>255) || sumLiters>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumLiters -= liters;
                }
                

            }
            Console.WriteLine(sumLiters);
        }
    }
}
