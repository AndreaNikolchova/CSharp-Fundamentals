using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string line = Console.ReadLine();
           List<string> list =line.Split(", ").ToList();
            for (int i = 0; i < list.Count; i++)
            {
                char[] word = list[i].ToCharArray();
                if (word.Length>=3&& word.Length<=16)
                {
                   foreach(char s in word)
                    {
                        if (char.IsLetterOrDigit(s) || s == '-' || s == '_')
                        {
                            continue;
                        }
                        else
                        {
                          list.Remove(list[i]);
                            i--;
                            break;
                        }
                    }
                }
                else
                {
                    list.Remove(list[i]);
                    i--;
                }
                
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
