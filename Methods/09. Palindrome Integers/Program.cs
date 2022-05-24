using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Do();
        }
       static void Do()
        {
            string word = Console.ReadLine();
            while (word!="END")
            {
                if (word==ReverseString(word))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                word = Console.ReadLine();
            }
        }
        static string ReverseString(string word)
        {
            char []arrayWord2 = word.ToCharArray();
            Array.Reverse(arrayWord2);
            return String.Join("",arrayWord2);
        }
    }
}
