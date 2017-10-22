using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main()
        {
            ulong distance = ulong.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            ulong allTimeInSeconds = (ulong)(hours * 3600) + (ulong)(minutes * 60) + (ulong)seconds;

            Console.WriteLine((float)distance / allTimeInSeconds);
            Console.WriteLine(((float)distance / 1000) / ((float)allTimeInSeconds / 3600));
            Console.WriteLine(((float)distance / 1609) / ((float)allTimeInSeconds / 3600));
        }
    }
}
