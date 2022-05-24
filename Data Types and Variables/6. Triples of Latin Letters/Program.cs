using System;

namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                char firstChar = (char)('a' + i);
                for (int r = 0; r < number; r++)
                {
                    char secondChar = (char)('a' + r);
                    for (int j = 0; j < number; j++)
                    {
                        char thirdChar = (char)('a' + j);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
