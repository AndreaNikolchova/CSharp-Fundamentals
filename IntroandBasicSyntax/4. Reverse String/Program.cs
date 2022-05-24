using System;

namespace _4._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            char[] array = username.ToCharArray();
            string password = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char letter = array[i];
                password += letter.ToString();

            }
            Console.WriteLine(password);
        }
    }
}
