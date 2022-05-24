using System;

namespace _13._Debug_the_Code_Holidays_Between_Two_Dates
{
    class Program
    {
        class HolidaysBetweenTwoDates
        {
            static void Main()
            {
                 var startDate = DateTime.ParseExact(Console.ReadLine(),
                    "d.M.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                var endDate = DateTime.ParseExact(Console.ReadLine(),
                    "d.M.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                var holidaysCount = 0;
                for (var date = startDate; date <= endDate; date = date.AddDays(1))
                    if (date.DayOfWeek == DayOfWeek.Saturday ||
                        date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
                Console.WriteLine(holidaysCount);
                //There are 5 non - working days(Saturday / Sunday) in this period:
                ////1 - May - 2016, 7 - May - 2016, 8 - May - 2016, 14 - May - 2016, 15 - May - 2016

            }
        }

    }
}
