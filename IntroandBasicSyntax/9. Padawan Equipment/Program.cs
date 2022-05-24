using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bujet = double.Parse(Console.ReadLine()); 
            int countOfStudents =int.Parse(Console.ReadLine());
            double priceOfLightsaber=double.Parse(Console.ReadLine());  
            double priceOfRobes=double.Parse(Console.ReadLine());
            double priceOfBelts =double.Parse(Console.ReadLine());
            int count = 0;
            double sum = 0;
            //            Needed equipment for 2 padawans  :
            //sabresPrice * (studentsCount + 10 %) + robesPrice * (studentsCount) + beltsPrice * (studentsCount - freeBelts)
            //1 * (3) + 2 * (2) + 3 * (2) = 13.00
            //13.00 <= 100 – the money will be enough.

            priceOfLightsaber *= (countOfStudents + Math.Ceiling(countOfStudents * 0.10));
            priceOfRobes *= countOfStudents;
            for (int i = 1; i <=countOfStudents; i++)
            {
                if (i%6==0)
                {
                    count++;
                }
                
            }
            priceOfBelts *= (countOfStudents - count);
            sum = priceOfBelts + priceOfRobes + priceOfLightsaber;
            if (sum>bujet)
            {
                Console.WriteLine($"John will need {(sum-bujet):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
        }
    }
}
