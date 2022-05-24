using System;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeat = Console.ReadLine();
            int repeatLength = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(repeat,repeatLength));

        }
        static string RepeatString(string repeat , int lenght)
        {
            string result = string.Empty;
            for (int i = 1; i <= lenght; i++)
            {
                result = result + repeat;

            }
            return result;
        }
    }
}
