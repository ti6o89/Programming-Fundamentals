using System;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse) .ToList();
            int sum = 0;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                numbers.Reverse();
                sum += numbers[i];
            }
            Console.WriteLine(string.Join("",sum));
        }
    }
}
