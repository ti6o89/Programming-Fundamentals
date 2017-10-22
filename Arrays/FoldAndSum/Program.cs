using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] firstRow = new int[numbers.Length / 2];
            int[] secondRow = new int[numbers.Length / 2];
            int k = numbers.Length / 4;

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = numbers[k - i - 1];
            }
            for (int i = 0; i < k; i++)
            {
                firstRow[k + i] = numbers[4 * k - 1 - i];
            }
            for (int i = 0; i < 2*k; i++)
            {
                secondRow[i] = numbers[k + i];
            }
            for (int i = 0; i < 2*k; i++)
            {
                Console.Write(firstRow[i]+secondRow[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
