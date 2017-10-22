﻿using System;
using System.Linq;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var count = new int[1001];
            foreach (var num in nums)
            {
                count[num]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                Console.WriteLine($"{i} -> {count[i]}");
            }
        }
    }
}
