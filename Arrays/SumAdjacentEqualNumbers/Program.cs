﻿using System;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i-1]==nums[i])
                {
                    nums[i - 1] += nums[i];
                    nums.RemoveAt(i);
                    i=i-2;
                    if (i<0)
                    {
                        i = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",nums));

        }
    }
}
