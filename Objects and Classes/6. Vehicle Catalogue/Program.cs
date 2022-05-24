using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    internal class Program
    {
        class Catalog
        {
            public string TypeOfCar { get; set; }
            public string Name { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
            public Catalog(string type,string name,string color,double horsepower)
            {
                this.TypeOfCar = type;
                this.Name = name;
                this.Color = color;
                this.Horsepower = horsepower;
            }

        }
       

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Catalog> listCars = new List<Catalog>();
            int count = 0;  
            while (command!= "End")
            {
                if (count==50)
                {
                    break;
                }
                List<string> list = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                listCars.Add(new Catalog(list[0], list[1], list[2], double.Parse(list[3])));
                command = Console.ReadLine();
                count++;
            } 
            string newCommand = Console.ReadLine();
            List<double> newListCar = new List<double>();
            List<double> newListTruck = new List<double>();
            int newcount = 0;
            while (newCommand!= "Close the Catalogue")
            {
                if(newcount==50)
                {
                    break;
                }
              int index = listCars.FindIndex(x=>x.Name==newCommand);
                Console.WriteLine($"Type: {char.ToUpper(listCars[index].TypeOfCar[0])+ listCars[index].TypeOfCar.Substring(1)}");
                Console.WriteLine($"Model: {listCars[index].Name}");
                Console.WriteLine($"Color: {listCars[index].Color}");
                Console.WriteLine($"Horsepower: {listCars[index].Horsepower}");
                newCommand = Console.ReadLine();
                newcount++;

            }
            for (int i = 0; i < listCars.Count; i++)
            {
                if (listCars[i].TypeOfCar == "car")
                {
                    newListCar.Add(listCars[i].Horsepower);
                }
                else if (listCars[i].TypeOfCar == "truck")
                {

                    newListTruck.Add(listCars[i].Horsepower);
                }
               
            }
            if (newListCar.Count==0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {newListTruck.Average():f2}.");
                return;
            }
            if (newListTruck.Count==0)
            {
                Console.WriteLine($"Cars have average horsepower of: {newListCar.Average():f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
                return;
            }
          
             Console.WriteLine($"Cars have average horsepower of: {newListCar.Average():f2}.");
             Console.WriteLine($"Trucks have average horsepower of: {newListTruck.Average():f2}.");
           
           

        }
    }
}
