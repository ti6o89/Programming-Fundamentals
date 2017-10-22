using System;
using System.Linq;

namespace ExtractMiddle1_2or3Elements
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = ExtractMiddleElemets(nums);
            Console.WriteLine("{" + string.Join(", ", result) + "}");
        }

        private static int[] ExtractMiddleElemets(int[] nums)
        {
            if (nums.Length==1)
            {
                return nums;
            }
            if (nums.Length % 2 ==0)
            {
                return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2] };
            }
            return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2], nums[nums.Length / 2 + 1] };
        }
    }
}
