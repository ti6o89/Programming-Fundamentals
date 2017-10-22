using System;

namespace TripleSum
{
    class Program
    {
        static void Main()
        {
            string[] arrayNumber = Console.ReadLine().Split();
            int[] array = new int[arrayNumber.Length];
            bool isTrue = false;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(arrayNumber[i]);
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                int firstNum = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    int secondNum = array[j];
                    int sum = firstNum + secondNum;
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (array[k]==sum)
                        {
                            Console.WriteLine($"{firstNum} + {secondNum} == {sum}");
                            isTrue = true;
                        }
                    }
                }
            }
            if (!isTrue)
            {
                Console.WriteLine("No");
            }
        }
    }
}
