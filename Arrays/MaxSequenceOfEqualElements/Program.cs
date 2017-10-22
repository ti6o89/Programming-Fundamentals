using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1;
            int besCount = 0;
            int start = 0;
            int sequenceNUmber = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]==numbers[i+1])
                {
                    count++;
                }
                else if (numbers[i] != numbers[i+1])
                {
                    count = 1;
                    start = i;
                }
                if (count>besCount)
                {
                    besCount = count;
                    sequenceNUmber = numbers[i];

                }

            }
            int[] result = new int[besCount];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = sequenceNUmber;  
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
