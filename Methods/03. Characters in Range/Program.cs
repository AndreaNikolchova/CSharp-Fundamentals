using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetLine();

        }
        static void GetLine()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            int start = (int)first;
            int end = (int)second;
            char letter = ' ';
            if ((int)second < (int)first)
            {
                end = (int)first;
                start = (int)second;
            }
            for (int i = start+1; i < end; i++)
            {
                letter = (char)i;
                Console.Write($"{letter} ");
            }
        }
    }
}
