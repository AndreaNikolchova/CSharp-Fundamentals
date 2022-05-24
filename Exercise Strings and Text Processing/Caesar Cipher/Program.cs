using System;
using System.Collections.Generic;

namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().Trim(' ');
            char[] chars = word.ToCharArray();
            List<char> list = new List<char>();
            for (int i = 0; i<chars.Length; i++)
            {
                int code = (int)chars[i] + 3;
                list.Add((char)code);
            }
            foreach(var c in list)
            {
                Console.Write(c);
            }


        }
    }
}
