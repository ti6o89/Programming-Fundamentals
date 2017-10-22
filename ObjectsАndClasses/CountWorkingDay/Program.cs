using System;
using System.Collections.Generic;
using System.Globalization;

namespace CountWorkingDay
{
    class Program
    {
        static void Main()
        {
            string firstDate = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(
                                                firstDate, "dd-M-yyyy",
                                                 CultureInfo.InvariantCulture);
            string secondDate = Console.ReadLine();
            DateTime endDate = DateTime.ParseExact(
                                            secondDate, "dd-M-yyyy",
                                             CultureInfo.InvariantCulture);

            int workDays = 0;
            List<DateTime> holydays = new List<DateTime>();
            holydays.Add(new DateTime(2016, 01, 01));
            holydays.Add(new DateTime(2016, 03, 03));
            holydays.Add(new DateTime(2016, 05, 01));
            holydays.Add(new DateTime(2016, 05, 06));
            holydays.Add(new DateTime(2016, 05, 24));
            holydays.Add(new DateTime(2016, 09, 06));
            holydays.Add(new DateTime(2016, 09, 22));
            holydays.Add(new DateTime(2016, 11, 01));
            holydays.Add(new DateTime(2016, 12, 24));
            holydays.Add(new DateTime(2016, 12, 25));
            holydays.Add(new DateTime(2016, 12, 26));

            for (DateTime curentDate = startDate; curentDate <= endDate; curentDate=curentDate.AddDays(1))
            {
                DateTime newDate = new DateTime(2016, curentDate.Month, curentDate.Day);
                if (!holydays.Contains(newDate) && curentDate.DayOfWeek !=DayOfWeek.Saturday && 
                    curentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workDays++;
                    
                }
            }
            Console.WriteLine(workDays);
        }
    }
}
