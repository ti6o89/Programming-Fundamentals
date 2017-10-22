using System;
using System.Linq;

namespace ReverseAnArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(input);

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
