using System;
using System.Linq;

namespace CondenseArraytoNumber
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (nums.Length>=2)
            {
                var result = new int[nums.Length - 1];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = nums[i] + nums[i + 1];
                }
                nums = result;
            }
            if (nums.Length<2)
            {
                Console.WriteLine("{0} is already condensed to number",nums[0]);
            }
            else
            {
                Console.WriteLine(nums[0]);
            }
        }
    }
}
