using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetVowells();
        }
        static void GetVowells()
        {
            int count = 0;
            string word = Console.ReadLine().ToLower();
            char[] chars = word.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'a':
                    case 'o':
                    case 'e':
                    case 'i':
                    case 'u':
                        count++;
                        break;
     
                }
            }
            Console.WriteLine(count);
        }
    }
}
