using System;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ');
            string[] second = Console.ReadLine().Split(' ');
           
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first[i]==second[j])
                    {
                        Console.Write(second[j] + " ");
                    } 
                    
                }
                
            }
            
        }
    }
}
