using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._SoftUni_Parking
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> parkingList = new Dictionary<string, string>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                List<string> line = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
                if (line[0] == "register")
                {
                    string value = string.Empty;
                    if (parkingList.ContainsKey(line[1]))
                    {
                        foreach (var car in parkingList)
                        {
                            if (car.Value == line[2])
                            {
                                value = car.Value;
                                break;
                            }
                        }
                        Console.WriteLine($"ERROR: already registered with plate number {value}");
                    }
                    else
                    {
                        parkingList.Add(line[1], line[2]);
                        Console.WriteLine($"{line[1]} registered {line[2]} successfully");
                    }
                }
                else
                {
                    if (!parkingList.ContainsKey(line[1]))
                    {
                        Console.WriteLine($"ERROR: user {line[1]} not found");
                    }
                    else
                    {
                        foreach (var car in parkingList)
                        {
                            if (car.Key == line[1])
                            {
                                parkingList.Remove(car.Key);
                            }
                        }
                        Console.WriteLine($"{line[1]} unregistered successfully");
                    }
                }
            }
            foreach (var item in parkingList)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
