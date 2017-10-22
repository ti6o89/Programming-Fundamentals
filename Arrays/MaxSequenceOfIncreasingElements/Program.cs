using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int bestCount = 0;
            int lastNumber = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i+1] - numbers[i]==1)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count>bestCount)
                {
                    bestCount = count;
                    lastNumber = numbers[i] + 1;
                }
            }
            int[] result = new int[bestCount];
            for (int i = 0; i < result.Length; i++)
            {       
                result[i] = (lastNumber+1) - bestCount;
                bestCount--;
            }
            Console.WriteLine(bestCount);
            Console.WriteLine(lastNumber);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
