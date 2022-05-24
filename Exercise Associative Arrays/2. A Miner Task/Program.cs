using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resorses = new Dictionary<string, long>();
            string line = Console.ReadLine();
            int count = 0;
            string help = " ";
            while (line != "stop")
            {
                count++;
                
                if (count % 2 != 0)
                {
                    if (!resorses.ContainsKey(line))
                    {
                    resorses.Add(line, 0);
                    }    
                    help = line;
                }
                else
                {
                    resorses[help]+=long.Parse(line);
                }
            line = Console.ReadLine();
            }
            foreach(var item in resorses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
