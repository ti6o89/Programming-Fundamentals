using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (number>=1 && number<=7)
            {
                Console.WriteLine(days[number-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
