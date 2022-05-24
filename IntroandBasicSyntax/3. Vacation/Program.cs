using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine()); 
            string vacation=Console.ReadLine();
            string day=Console.ReadLine();
            double money = 0;
            double moneyBisness=0;
            switch (vacation) 
            {
                case "Students":
                    
                    if (day == "Friday")
                    {
                        money += 8.45 * people;
                    }
                    else if (day == "Saturday")
                    {
                        money += 9.80 * people;
                    }
                    else if (day== "Sunday")
                    {
                        money += 10.46 * people;
                    }
                    if (people >= 30)
                    {
                        money *= 0.85;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        money += 10.90 * people;
                        moneyBisness = 10 * 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        money += 15.60 * people;
                        moneyBisness = 10 * 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        money += 16.0 * people;
                        moneyBisness = 10 * 16;
                    }
                    if (people>=100)
                    {
                        money -= moneyBisness;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        money += 15.0 * people;
                    }
                    else if (day == "Saturday")
                    {
                        money += 20.0 * people;
                    }
                    else if (day == "Sunday")
                    {
                        money += 22.50 * people;
                    }
                    if (people<=20&&people>=10)
                    {
                        money *= 0.95;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {money:f2}");

        }
    }
}
