using System;
using System.Collections.Generic;
using System.Globalization;

namespace p01_CountWorkingDays
{
    class P01
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int counterWorkingDays = 0;

            List<string> holidays = new List<string>() {
                "1 Jan", "3 Mar", "1 May", "6 May", "24 May",
                "6 Sep", "22 Sep", "1 Nov", "24 Dec", "25 Dec",
                "26 Dec"
            };

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }
                else if(holidays.Contains(i.ToString("d MMM")))
                {
                    continue;
                }
                counterWorkingDays++;
            }
            Console.WriteLine(counterWorkingDays);
        }
    }
}
