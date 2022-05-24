using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n= int.Parse(Console.ReadLine());
            decimal r = 0;
            decimal h = 0;
            decimal sum = 0;
            decimal max = 10;
            string name = " ";
            string maxName = " ";
            for (int i = 1; i <=n ; i++)
            {
                name =Console.ReadLine();
                r = decimal.Parse(Console.ReadLine());
                h = decimal.Parse(Console.ReadLine());
                sum = (decimal)Math.PI*r*r*h;
                if (sum>max)
                {
                    max= sum;
                    maxName=name;
                }

            }
            Console.WriteLine(maxName);
        }
    }
}
