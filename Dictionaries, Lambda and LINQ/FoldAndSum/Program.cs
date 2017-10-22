using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            int k = input.Length / 4;

            int[] firstRow = input.Take(k).Reverse().ToArray();
            int[] lastRow = input.Reverse().Take(k).ToArray();
            int[] firstAndLast = firstRow.Concat(lastRow).ToArray();
            int[] middleNumbers = input.Skip(k).Take(2 * k).ToArray();
            var sum = firstAndLast.Select((x, index) => x + middleNumbers[index]);
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
