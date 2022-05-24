using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    internal class Program
    {
        class matches
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public matches(string name,string price ,string quantity)
            {
                this.Name=  name;
                this.Price = double.Parse(price);
                this.Quantity= int.Parse(quantity);
            }
        }

        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";
           string line = Console.ReadLine();
            List<matches> matches = new List<matches>();    
            while (line!= "Purchase")
            {
                MatchCollection Matches = Regex.Matches(line, pattern, RegexOptions.IgnoreCase);
                foreach (Match match in Matches)
                {
                    matches.Add(new matches(match.Groups["name"].ToString(), match.Groups["price"].ToString(), match.Groups["quant"].ToString()));
                }
                line = Console.ReadLine();  
               
            }
            double sum = 0;
            Console.WriteLine("Bought furniture:");
            if (matches.Count>0)
            {
            foreach (var item in matches)
            {
                if (item.Name!= String.Empty)
                {
                    Console.WriteLine(item.Name);
                    sum+=item.Price*item.Quantity;
                }
            }

            }
            Console.WriteLine($"Total money spend: {sum:f2}");

           


        }
    }
}
