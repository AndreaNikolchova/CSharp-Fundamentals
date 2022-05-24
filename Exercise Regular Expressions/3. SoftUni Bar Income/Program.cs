using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    internal class Program
    {
        class Shift
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public decimal Price { get; set; }
            public Shift(string name,string value,decimal price)
            {
                this.Name = name;
                this.Value = value;
                this.Price = price;
            }
        }

        static void Main(string[] args)
        {
            string pattern = @"[%](?<name>[A-Z][a-z]+)[%][^|$%.]*[<](?<nameOfProduxt>[A-Za-z]+)[>][^|$%.]*[|](?<quantity>\d+)[|][a-z|^[|$%.|]*(?<price>\d+(.\d+)|\d+)([$])";
            string imput = Console.ReadLine();
            List<Shift> shift = new List<Shift>();
            while (imput!= "end of shift")
            {
                Match match = Regex.Match(imput, pattern);
                if (match.Success)
                {
                    decimal priceAll =(decimal)int.Parse(match.Groups["quantity"].ToString()) * decimal.Parse(match.Groups["price"].ToString());
                    if (priceAll <=0)
                    {
                        shift.Add(new Shift(match.Groups["name"].ToString(), match.Groups["nameOfProduxt"].ToString(), 0));
                        
                    }
                    else
                    {

                    shift.Add(new Shift(match.Groups["name"].ToString(), match.Groups["nameOfProduxt"].ToString(),priceAll));
                        
                    }
                }
                imput = Console.ReadLine();
              

            }
            decimal sum = 0;
            foreach(Shift shif in shift)
            {
                Console.WriteLine($"{shif.Name}: {shif.Value} - {shif.Price:f2}");
               sum+= shif.Price;
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
