using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string imput = Console.ReadLine();
            double money = 0;
            while (imput!= "Start")
            {
                
                if (imput=="Start")
                {
                    return;
                }
                else
                {
                    switch (imput)
                    {
                        case "0.1":
                        case "0.2":
                        case "0.5":
                        case "1":
                        case "2":
                            money+= double.Parse(imput);
                            break;
                        default:
                            Console.WriteLine("Cannot accept "+imput);
                            break;
                    }
                    
                }
                imput = Console.ReadLine();
            }
           
           
            string food= Console.ReadLine();
            while (food!="End")
            {
                
                switch (food)
                {
                    case "Nuts":
                        if (money<2.0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            money -= 2.00;
                            Console.WriteLine("Purchased nuts");
                        }
                        break;
                    case "Water":
                        if (money < 0.7)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            money -= 0.70;
                            Console.WriteLine("Purchased water");
                        }
                        break;
                    case "Crisps":
                        if (money < 1.5)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            money -= 1.50;
                            Console.WriteLine("Purchased crisps");
                        }
                        break;
                    case "Soda":
                        if (money < 0.8)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            money -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        break;
                    case "Coke":
                        if (money < 1.0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            money -= 1.00;
                            Console.WriteLine("Purchased coke");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                food = Console.ReadLine();  
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
