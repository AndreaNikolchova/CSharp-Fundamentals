using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void RemoveSpace(List<char> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == ' ')
                {
                    words.RemoveAt(i);
                }
            }
            
        }
        static void Main(string[] args)
        {
            List<char> words = Console.ReadLine().ToCharArray().ToList();
            Dictionary<char,int> letterCount = new Dictionary<char,int>();
            RemoveSpace(words);
            foreach (var letter in words)
            {
                if (letterCount.ContainsKey(letter))
                {
                    letterCount[letter]++;
                }
                else
                {
                    letterCount.Add(letter, 1);
                }
            }
            foreach(var leter in letterCount)
            {
                Console.WriteLine($"{leter.Key} -> {leter.Value}");
            }
           
            
        }
    }
}
