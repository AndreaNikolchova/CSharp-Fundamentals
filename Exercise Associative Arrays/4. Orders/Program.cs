using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    internal class Program
    {
        class Price
        {
            public string Item { get; set; }
            public decimal PriceOfItem { get; set; }
            public int Quantity { get; set; }
            public Price(string item, decimal price, int quantity)
            {
                this.Item = item;
                this.PriceOfItem = price;
                this.Quantity = quantity; 
            }

             
        }


        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string,decimal> orders = new Dictionary<string,decimal>();
            List<Price> priceList = new List<Price>();
            while (line != "buy")
            {
                string[] ordersLine = line.Split();
                decimal price = decimal.Parse(ordersLine[1]) * decimal.Parse(ordersLine[2]);
                int quantity = int.Parse(ordersLine[2]);
                priceList.Add(new Price(ordersLine[0], decimal.Parse(ordersLine[1]), int.Parse(ordersLine[2])));
                if (orders.ContainsKey(ordersLine[0]))
                {
                    int index = priceList.FindIndex(x=>x.Item == ordersLine[0]);
                    orders[ordersLine[0]] = decimal.Parse(ordersLine[1])*(decimal)(priceList[index].Quantity+=quantity);
                }
                else
                { 
                    orders.Add(ordersLine[0], price);
                }
                line = Console.ReadLine();
            }
            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
