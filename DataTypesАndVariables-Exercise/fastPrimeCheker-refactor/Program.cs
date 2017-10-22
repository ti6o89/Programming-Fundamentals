using System;

namespace fastPrimeCheker_refactor
{
    class Program
    {
        static void Main()
        {
            int numberRange = int.Parse(Console.ReadLine());
            for (int num = 2; num <= numberRange; num++)
            {
                bool prime = true;
                for (int divider = 2; divider <= Math.Sqrt(num); divider++)
                {
                    if (num % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {prime}");
            }

        }
    }
}
