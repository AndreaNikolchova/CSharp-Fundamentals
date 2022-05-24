using System;
using System.Collections.Generic;

namespace _1._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<string> phrases = new List<string>()
                {"Excellent product.", 
              "Such a great product.", 
              "I always use that product.", 
              "Best product of its category.", 
              "Exceptional product.",
              "I can’t live without this product."};
            List<string> events = new List<string>()
                {"Now I feel good.", 
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", 
                "I feel great!"};
            List<string> names = new List<string>()
            { "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva" };
            List<string> values = new List<string>()
               { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            Random rnd = new Random();
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
               int randomPhrses = rnd.Next(0,phrases.Count);
               int randomEvents = rnd.Next(0,events.Count);
               int randomNames = rnd.Next(0,names.Count);
               int randomValues = rnd.Next(0,values.Count);
                Console.WriteLine($"{phrases[randomPhrses]} {events[randomEvents]} {names[randomNames]} – {values[randomValues]}.");
            }
        }
    }
}
