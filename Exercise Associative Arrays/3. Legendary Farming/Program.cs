using System;
using System.Collections.Generic;

namespace _3._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> money = new Dictionary<string, int>();
            Dictionary<string,int> junk = new Dictionary<string, int>();    
            int valueOfShards = 0;
            int valueOfFragments = 0;
            int valueOfMotes = 0;
            money.Add("shards", 0);
            money.Add("fragments", 0);
            money.Add("motes", 0);
            while (true)
            {
                string[] array = Console.ReadLine().ToLower().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i <= array.Length-1; i+=2)
                {
                    if (money.ContainsKey(array[i]))
                    {
                        money[array[i]] += int.Parse(array[i - 1]);
                        if (money["shards"] >= 250)
                        {
                            break;
                        }
                        else if (money["fragments"] >= 250)
                        {
                            break;
                        }
                        else if (money["motes"] >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(array[i]))
                        {
                            junk.Add(array[i], int.Parse(array[i - 1]));
                        }
                        else
                        {
                            junk[array[i]] += int.Parse(array[i - 1]);
                        }
                    }
                }
                    if (money["shards"] >= 250)
                    {
                        break;
                    }
                    else if (money["fragments"] >= 250)
                    {
                        break;
                    }
                    else if (money["motes"] >= 250)
                    {
                        break;
                    }
               
            }
            foreach (var mne in money)
            {
                switch (mne.Key)
                {
                    case "shards":
                        valueOfShards += mne.Value;
                        break;
                    case "fragments":
                        valueOfFragments += mne.Value;
                        break;
                    case "motes":
                        valueOfMotes += mne.Value;
                        break;
                }
            }
            Print(money,valueOfShards,valueOfFragments,valueOfMotes,junk);
        }
        static void Print(Dictionary<string,int> money,int shards,int frangments,int motes,Dictionary<string,int> junk)
        {
            foreach(var mne in money)
            {
                if (mne.Value>=250)
                {
                    switch (mne.Key)
                    {
                        case "shards":
                            Console.WriteLine("Shadowmourne obtained!");
                            Console.WriteLine($"shards: {shards-250}");
                            Console.WriteLine($"motes: {motes}");
                            Console.WriteLine($"fragments: {frangments}");
                            foreach (var item in junk)
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            return;
                            
                        case "fragments":
                            Console.WriteLine("Valanyr obtained!");
                            Console.WriteLine($"shards: {shards}");
                            Console.WriteLine($"motes: {motes}");
                            Console.WriteLine($"fragments: {frangments-250}");
                            foreach (var item in junk)
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            return;

                           
                        case "motes":
                            Console.WriteLine("Dragonwrath obtained!");
                            Console.WriteLine($"shards: {shards}");
                            Console.WriteLine($"motes: {motes-250}");
                            Console.WriteLine($"fragments: {frangments}");
                            foreach (var item in junk)
                            {
                                Console.WriteLine($"{item.Key}: {item.Value}");
                            }
                            return;
                            
                    }
                }
            } 
        }  
    }
}
