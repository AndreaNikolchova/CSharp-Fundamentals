using System;

namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capasity = int.Parse(Console.ReadLine());
            int sumOfCourses = (int)Math.Ceiling((double)people / capasity);
            Console.WriteLine(sumOfCourses);

        }
    }
}
