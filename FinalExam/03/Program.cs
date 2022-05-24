using System;
using System.Collections.Generic;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, List<string>> heros = new Dictionary<string, List<string>>();
            while (line != "End")
            {
                string[] command = line.Split(" ");
                switch (command[0])
                {
                    case "Enroll":
                        if (heros.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"{command[1]} is already enrolled.");
                        }
                        else
                        {
                            heros.Add(command[1], new List<string>());
                        }
                        break;
                    case "Learn":
                        if (!heros.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"{command[1]} doesn't exist.");
                        }
                        else
                        {
                            if (heros[command[1]].Contains(command[2]))
                            {
                                Console.WriteLine($"{command[1]} has already learnt {command[2]}.");
                            }
                            else
                            {
                                heros[command[1]].Add(command[2]);
                            }
                        }
                        break;
                    case "Unlearn":
                        if (!heros.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"{command[1]} doesn't exist.");
                        }
                        else
                        {
                            if (heros[command[1]].Contains(command[2]))
                            {
                                heros[command[1]].Remove(command[2]);
                            }
                            else
                            {
                                Console.WriteLine($"{command[1]} doesn't know {command[2]}.");
                            }
                        }
                        break;

                }
                line = Console.ReadLine();
            }
            Console.WriteLine("Heroes:");
            foreach (var hero in heros)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");


            }

        }
    }
}
