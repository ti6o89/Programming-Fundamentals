using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split('|').ToList();
            input.Reverse();
            List<string> number = new List<string>();
            foreach (var item in input)
            {
                List<string> nums = item.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToList();
                number.AddRange(nums);
            }

            Console.WriteLine(string.Join(" ",number));
        }
    }
}
