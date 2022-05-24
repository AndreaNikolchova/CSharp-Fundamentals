using System;
using System.Text;

namespace _6.__Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder(); 
            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i] != word[i+1])
                {
                    sb.Append(word[i]);
                }

            }
            sb.Append(word[word.Length-1]);
            Console.WriteLine(sb.ToString());
        }
    }
}
