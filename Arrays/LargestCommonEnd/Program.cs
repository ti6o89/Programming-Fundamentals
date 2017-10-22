using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').ToArray();
            var arr2 = Console.ReadLine().Split(' ').ToArray();
            string[] arrMin = new string[Math.Min(arr1.Length, arr2.Length)];
            string[] arrMax = new string[Math.Max(arr1.Length, arr2.Length)];
            int counterLeft = 0;
            int counterRight = 0;

            for (int i = 0; i < arrMax.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    counterLeft++;
                }
            }
            int index = 1;
            for (int i = arrMin.Length-1; i >= 0; i--)
            {
                if (arr1[arr1.Length - index] == arr2[arr2.Length - index])
                {
                    counterRight++;
                    index++;
                }
            }

            Console.WriteLine(Math.Max(counterLeft, counterRight));
        }
    }
}
