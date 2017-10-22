using System;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int year = centuries * 100;
            int days = (int)(year * 365.2422);
            int hours = days * 24;
            ulong minutes =(ulong) hours * 60;
            ulong seconds = 60 * minutes;
            ulong miliseconds = 1000 * seconds;
            ulong microseconds = 1000 * miliseconds;
            ulong nanoseconds = (ulong)1000 * microseconds;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",centuries,year,days,hours,minutes,seconds,miliseconds,microseconds,nanoseconds);
        }
    }
}
