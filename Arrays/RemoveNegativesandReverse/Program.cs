using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int count = 0;

            foreach (var item in input)
            {
                if (item > 0)
                {
                    result.Add(item);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("empty");
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
