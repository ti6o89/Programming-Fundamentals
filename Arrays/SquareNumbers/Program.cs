using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareNumbers = new List<int>();

            foreach (var num in numbers)
            {
                if (IsExactSquare(num))
                {
                    squareNumbers.Add(num);
                }
            }
            squareNumbers.Sort();
            squareNumbers.Reverse();
            Console.WriteLine(string.Join(" ",squareNumbers));
        }

        static bool IsExactSquare(int num)
        {
            var sqrt = (int)Math.Sqrt(num);
            return (sqrt * sqrt == num);

        }
    }
}
