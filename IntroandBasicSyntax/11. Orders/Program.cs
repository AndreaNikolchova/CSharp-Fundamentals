using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            double orderprice = 0;
            double sumOfOrders = 0;
            for (int i = 0; i < n; i++)
            {
                orderprice = 0;
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());   
                int count = int.Parse(Console.ReadLine());
                orderprice = price * days * count;
                Console.WriteLine($"The price for the coffee is: ${orderprice:f2}");
                sumOfOrders += orderprice;
                
            }
            Console.WriteLine($"Total: ${sumOfOrders:f2}");
        }
    }
}
