using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\W\w]+)>(\d{3})[|]([a-z]{3})[|]([A-Z]{3})[|]([^<>]{3})<([\W\w]+)";
            int number = int.Parse(Console.ReadLine());
            for (int i =  1; i <= number; i++)
            {
                string line = Console.ReadLine();
                Match match = Regex.Match(line, pattern);
                if (match.Success)
                {
                    if (match.Groups[1].Value==match.Groups[6].Value)
                    {
                        string result = match.Groups[2].Value+ match.Groups[3].Value+ match.Groups[4].Value + match.Groups[5].Value;
                        Console.WriteLine($"Password: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Try another password!");
                    }
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
