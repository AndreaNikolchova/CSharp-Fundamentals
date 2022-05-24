using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string word = Console.ReadLine();
          char[] wordArray = word.ToCharArray();
            Check(wordArray);
        }
        static void Check(char[] array)
        {
            if (array.Length%2==0)
            {
                Even (array);
            }
            else
            {
                Console.WriteLine(array[array.Length / 2]);
            }
        }
        static void Even(char[] array)
        {
            Console.WriteLine($"{array[(array.Length - 1) / 2] }{array[array.Length / 2]}");       
        }
    }
}
