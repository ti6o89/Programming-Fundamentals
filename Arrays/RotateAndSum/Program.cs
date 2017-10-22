using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            long[] sum = new long[nums.Length];

            for (int i = 0; i < k; i++)
            {
                int lastNumber = nums[nums.Length - 1];
                for (int j = nums.Length-1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = lastNumber;

                for (int z = 0; z < nums.Length; z++)
                {
                    sum[z] += nums[z];
                }
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
