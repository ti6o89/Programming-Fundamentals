using System;

namespace RoundingNumbersAwayfromZero
{
    class Program
    {
        static void Main()
        {
            string[] nums = Console.ReadLine().Split();
            double[] roundedNumers = new double[nums.Length];
            

            for (int i = 0; i < roundedNumers.Length; i++)
            {
                roundedNumers[i] = double.Parse(nums[i]);
            }

            int[] numbersRound = new int[roundedNumers.Length];
            for (int i = 0; i < roundedNumers.Length; i++)
            {
                numbersRound[i] = (int)Math.Round(roundedNumers[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < roundedNumers.Length; i++)
            {
                Console.WriteLine($"{roundedNumers[i]} => {numbersRound[i]}");
            }
        }
    }
}
