using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int mostFreqNum = nums[0];
            int current = nums[0];
            int count = 1;
            int maxCount = 1;

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            mostFreqNum = nums[i];
                            maxCount = count;
                        }
                    }
                }

                count = 1;
            }

            Console.WriteLine(mostFreqNum);
        }
    }
}
