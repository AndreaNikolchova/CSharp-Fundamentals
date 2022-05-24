using System;

namespace _1._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] days = new string[] {"Monday","Tuesday", "Wednesday", "Thursday","Friday","Saturday","Sunday"};
            if (number>0&&number<=days.Length)
            {
                Console.WriteLine(days[number-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
