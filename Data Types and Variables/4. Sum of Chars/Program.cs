using System;

namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char letter = ' ';
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
               letter=char.Parse(Console.ReadLine());
                sum+= (int)letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
